﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Npgsql;
using NpgsqlTypes;

namespace Program
{
    public class FacultyIdToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!System.Convert.IsDBNull(value))
            {
                int facultyId = (int)value;
                if (MainWindow.FacultyIdName.ContainsKey(facultyId))
                {
                    return MainWindow.FacultyIdName[facultyId];
                }
                // Если ключ отсутствует, вернуть значение по умолчанию или что-то другое
                return "Нет значения для ID: " + facultyId;
            }
            return null;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!System.Convert.IsDBNull(value))
            {
                string facultyName = (string)value;
                return MainWindow.FacultyIdName.FirstOrDefault(x => x.Value == facultyName).Key;
            }
            return null;
        }
    }

    public partial class MainWindow : Window
    {
        private readonly NpgsqlConnection _connection;
        private NpgsqlCommand _firstCommand;
        private NpgsqlCommand _secondCommand;
        private NpgsqlDataAdapter _firstAdapter;
        private NpgsqlDataAdapter _secondAdapter;
        private DataTable _firstDataTable;
        private DataTable _secondDataTable;
        private readonly string _firstQuery = "select id, capital, title, continent_id, photo from country";
        private readonly string _secondQuery = "select id, title, date_create from continent";
        public static Dictionary<int, string> FacultyIdName { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=c_sharp;User Id = postgres;Password=Ab110971!");
            _firstCommand = new NpgsqlCommand(_firstQuery, _connection);
            _secondCommand = new NpgsqlCommand(_secondQuery, _connection);
            _firstAdapter = new NpgsqlDataAdapter(_firstCommand);
            _secondAdapter = new NpgsqlDataAdapter(_secondCommand);
            _firstDataTable = new DataTable();
            _secondDataTable = new DataTable();
            _firstAdapter.Fill(_firstDataTable);
            _secondAdapter.Fill(_secondDataTable);
            firstDataGrid.ItemsSource = _firstDataTable.DefaultView;
            secondDataGrid.ItemsSource = _secondDataTable.DefaultView;
            FacultyIdName = new Dictionary<int, string>();
            foreach (DataRow row in _secondDataTable.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["title"];
                FacultyIdName[id] = name;
            }
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(_firstAdapter);
                _firstAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                _firstAdapter.Update(_firstDataTable);
                _firstDataTable.Clear();
                _firstAdapter.Fill(_firstDataTable);
                firstDataGrid.ItemsSource = _firstDataTable.DefaultView;
            }
            catch
            {
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataRow dataRow = _firstDataTable.NewRow();
            _firstDataTable.Rows.Add(dataRow);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItems = firstDataGrid.SelectedItems.Cast<DataRowView>().ToList();
                foreach (DataRowView dataRowView in selectedItems)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
                _firstAdapter.DeleteCommand = FirstCreateDeleteCommand();
                _firstAdapter.Update(_firstDataTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка обновления данных: " + ex.Message);
                return;
            }
        }

        private NpgsqlCommand FirstCreateDeleteCommand()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = _connection;
            command.CommandText = "delete from country where id = @id";
            command.Parameters.Add("@id", NpgsqlDbType.Integer);
            command.Parameters["@id"].SourceColumn = "id";
            return command;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeZoneInfo unspecifiedTimeZone = TimeZoneInfo.Local; // Здесь укажите ваш часовой пояс, если он не UTC
                TimeZoneInfo utcTimeZone = TimeZoneInfo.Utc;

                foreach (DataRow row in _secondDataTable.Rows)
                {
                    if (row["date_create"] is DateTime unspecifiedDateTime)
                    {
                        if (unspecifiedDateTime.Kind == DateTimeKind.Unspecified)
                        {
                            // Предположим, что unspecifiedDateTime на самом деле в UTC, и мы преобразуем его в локальное время
                            DateTime localDateTime = unspecifiedDateTime.ToLocalTime();
                            row["date_create"] = localDateTime;
                        }
                    }
                }
                NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(_secondAdapter);
                _secondAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                _secondAdapter.Update(_secondDataTable);
                _secondDataTable.Clear();
                _secondAdapter.Fill(_secondDataTable);
                secondDataGrid.ItemsSource = _secondDataTable.DefaultView;
                FacultyIdName = new Dictionary<int, string>();
                foreach (DataRow row in _secondDataTable.Rows)
                {
                    int id = (int)row["id"];
                    string name = (string)row["title"];
                    FacultyIdName[id] = name;
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления данных: " + ex.Message);
                return;
            }
            try
            {
                NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(_firstAdapter);
                _firstAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                _firstAdapter.Update(_firstDataTable);
                _firstDataTable.Clear();
                _firstAdapter.Fill(_firstDataTable);
                firstDataGrid.ItemsSource = _firstDataTable.DefaultView;
            }
            catch
            {
                return;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataRow dataRow = _secondDataTable.NewRow();
            _secondDataTable.Rows.Add(dataRow);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItems = secondDataGrid.SelectedItems.Cast<DataRowView>().ToList();
                foreach (DataRowView dataRowView in selectedItems)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
                _secondAdapter.DeleteCommand = SecondCreateDeleteCommand();
                _secondAdapter.Update(_secondDataTable);
            }
            catch
            {
                return;
            }
        }

        private NpgsqlCommand SecondCreateDeleteCommand()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = _connection;
            command.CommandText = "delete from continent where id = @id";
            command.Parameters.Add("@id", NpgsqlDbType.Integer);
            command.Parameters["@id"].SourceColumn = "id";
            return command;
        }

        private void firstDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItems = firstDataGrid.SelectedItems.Cast<DataRowView>().ToList();
                foreach (DataRowView dataRowView in selectedItems)
                {
                    DataRow dataRow = dataRowView.Row;
                    if (dataRow["photo"] != DBNull.Value && dataRow["photo"] is byte[])
                    {
                        byte[] bytes = (byte[])dataRow["photo"];
                        using (MemoryStream memoryStream = new MemoryStream(bytes))
                        {
                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.BeginInit();
                            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            bitmapImage.StreamSource = memoryStream;
                            bitmapImage.EndInit();
                            image.Source = bitmapImage;
                        }
                    }
                    else
                    {
                        image.Source = null;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                BitmapImage bitmapImage = new BitmapImage();
                using (FileStream fileStream = File.OpenRead(path))
                {
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = fileStream;
                    bitmapImage.EndInit();
                }
                image.Source = bitmapImage;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = image.Source as BitmapImage;
            if (bitmapImage != null)
            {
                byte[] bytes;
                JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    jpegBitmapEncoder.Save(memoryStream);
                    bytes = memoryStream.ToArray();
                }
                UpdateImageToDatabase(bytes);
            }
        }

        private void UpdateImageToDatabase(byte[] bytes)
        {
            int id = 0;
            var selectedItems = firstDataGrid.SelectedItems.Cast<DataRowView>().ToList();
            foreach (DataRowView dataRowView in selectedItems)
            {
                DataRow dataRow = dataRowView.Row;
                if ((int)dataRow["id"] > 0)
                {
                    id = (int)dataRow["id"];
                }
            }
            try
            {
                if (id != 0)
                {
                    _connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = _connection;
                    command.CommandText = "update country set photo = @image where id = @id";
                    command.Parameters.AddWithValue("@image", NpgsqlDbType.Bytea, bytes);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    _firstDataTable.Clear();
                    _firstAdapter.Fill(_firstDataTable);
                    firstDataGrid.ItemsSource = _firstDataTable.DefaultView;
                    _connection.Close();
                }
            }
            catch
            {
                return;
            }
        }

        private void firstDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}