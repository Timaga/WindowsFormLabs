// ignore_for_file: non_constant_identifier_names

import 'dart:convert';
import 'dart:io';

import 'package:dio/dio.dart';
import 'package:image_picker/image_picker.dart';

class CountryModel {
  int? id;
  String? capital;
  String? title;
  int? continentId;
  String? photo;

  CountryModel(
      {this.id, this.capital, this.title, this.continentId, this.photo});

  CountryModel.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    capital = json['capital'];
    title = json['title'];
    continentId = json['continentId'];
    photo = json['photo'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['capital'] = this.capital;
    data['title'] = this.title;
    data['continentId'] = this.continentId;
    data['photo'] = this.photo;
    return data;
  }

  Future<String> sendJsonGetCountry(
      XFile imageFile, String title, String capital, int cont) async {
    var dio = Dio(); // Создайте экземпляр Dio

    var url =
        'http://localhost:5129/api/Country/insert?capital=$capital&title=$title&continent_id=$cont'; // Замените на свой URL

    try {
      var fileBytes = await imageFile.readAsBytes();
      var formData = FormData.fromMap({
        'photo': MultipartFile.fromBytes(fileBytes, filename: 'photo.png'),
      });
      var response = await dio.post(
        url,
        data: formData,
      );
      if (response.statusCode == 200) {
        print('JSON отправлен успешно');
        final data = response.data;
        return data.toString();
      } else {
        throw Exception('Failed to load Link');
      }
    } catch (e) {
      throw Exception('Failed to load Link: $e');
    }
  }

  Future<List<CountryModel>> getCountry() async {
    try {
      final response =
          await Dio().get("http://localhost:5129/api/Country/select");
      if (response.statusCode == 200) {
        final data = response.data as List<dynamic>;
        final continents =
            data.map((item) => CountryModel.fromJson(item)).toList();
        return continents;
      } else {
        throw Exception('Failed to load continents');
      }
    } catch (e) {
      throw Exception('Failed to load continents: $e');
    }
  }

  Future<String> updateCountry(
      XFile imageFile, int id, String title, String capital, int cont) async {
    var dio = Dio();
    var url =
        'http://localhost:5129/api/Country/update?id=$id&title=$title&capital=$capital&continent_id=$cont';
    try {
      var fileBytes = await imageFile.readAsBytes();
      var formData = FormData.fromMap({
        'photo': MultipartFile.fromBytes(fileBytes, filename: 'photo.png'),
      });
      var response = await dio.put(
        url,
        data: formData,
      );
      if (response.statusCode == 200) {
        print('JSON отправлен успешно');
        final data = response.data;
        return data.toString();
      } else {
        throw Exception('Failed to load Link');
      }
    } catch (e) {
      throw Exception('Failed to load Link: $e');
    }
  }

  Future<String> DeleteCountry(int id) async {
    var dio = Dio(); // Создайте экземпляр Dio

    var url =
        'http://localhost:5129/api/Country/delete?id=$id'; // Замените на свой URL

    try {
      var response = await dio.delete(
        url,
      );

      if (response.statusCode == 200) {
        print('JSON отправлен успешно');
        final data = response.data;
        return data.toString();
      } else {
        throw Exception('Failed to load Link');
      }
    } catch (e) {
      throw Exception('Failed to load  Link: $e');
    }
  }
}
