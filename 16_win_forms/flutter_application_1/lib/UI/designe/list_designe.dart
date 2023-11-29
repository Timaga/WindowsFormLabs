import 'package:flutter/material.dart';

class ContinentList extends StatefulWidget {
  int id;
  String title;
  String dateCreate;
  ContinentList({super.key,required this.dateCreate,required this.id,required this.title});

  @override
  State<ContinentList> createState() => _ContinentListState();
}

class _ContinentListState extends State<ContinentList> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(height: 1,color: Colors.black,),
        Text("id : ${widget.id}"),
        Text("title : ${widget.title}"),
        Text("date_create : ${widget.dateCreate}"),
      ],
    );
  }
}
