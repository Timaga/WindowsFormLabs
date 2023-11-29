import 'dart:io';

import 'package:flutter/material.dart';

class CountryList extends StatefulWidget {
  int id;
  String Capital;
  String title;
  String name;
  Image photo;
  CountryList(
      {super.key,
      required this.id,
      required this.title,
      required this.photo,
      required this.Capital,
      required this.name});

  @override
  State<CountryList> createState() => _CountryListState();
}

class _CountryListState extends State<CountryList> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(
          height: 1,
          color: Colors.black,
        ),
        Text("id : ${widget.id}"),
        Text("Capital : ${widget.Capital}"),
        Text("title : ${widget.title}"),
        Text("Continent_name : ${widget.name}"),
        widget.photo,
      ],
    );
  }
}
