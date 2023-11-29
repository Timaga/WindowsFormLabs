// ignore_for_file: non_constant_identifier_names

import 'package:dio/dio.dart';

class ContinentModel {
  int? id;
  String? title;
  String? dateCreate;

  ContinentModel({this.id, this.title, this.dateCreate});

  ContinentModel.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    title = json['title'];
    dateCreate = json['date_create'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['title'] = this.title;
    data['date_create'] = this.dateCreate;
    return data;
  }

  Future<String> sendJsonGetContinents(Map<String, dynamic> jsonData,String title) async {
    var dio = Dio(); // Создайте экземпляр Dio

    var url =
        'http://localhost:5129/api/Continent/insert?title=$title'; // Замените на свой URL

    try {
      var response = await dio.post(
        url,
        data: jsonData,
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

  Future<List<ContinentModel>> getContinents() async {
    try {
      final response =
          await Dio().get("http://localhost:5129/api/Continent/select");
      if (response.statusCode == 200) {
        final data = response.data as List<dynamic>;
        final continents =
            data.map((item) => ContinentModel.fromJson(item)).toList();
        return continents;
      } else {
        throw Exception('Failed to load continents');
      }
    } catch (e) {
      throw Exception('Failed to load continents: $e');
    }
  }

  Future<String> UpdateContinents(
      Map<String, dynamic> jsonData, int id, String title) async {
    var dio = Dio(); // Создайте экземпляр Dio

    var url =
        'http://localhost:5129/api/Continent/update?id=$id&title=$title'; // Замените на свой URL

    try {
      var response = await dio.put(
        url,
        data: jsonData,
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

  Future<String> DeleteContinents(int id) async {
    var dio = Dio(); // Создайте экземпляр Dio

    var url =
        'http://localhost:5129/api/Continent/delete?id=$id'; // Замените на свой URL

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
