import 'package:flutter/material.dart';
import 'package:flutter_application_1/UI/countryUI.dart';
import 'package:flutter_application_1/UI/designe/list_designe.dart';
import 'package:flutter_application_1/UI/designe/theme_helper.dart';
import 'package:flutter_application_1/repos/continent_repos.dart';

class Continent extends StatefulWidget {
  const Continent({super.key});

  @override
  State<Continent> createState() => _ContinentState();
}

var jsonData = {"ticks": 30};

class _ContinentState extends State<Continent> {
  List<Widget> widg = [];
  int id = 1;
  String title = "";
  bool IsInSERT = true;
  late List<ContinentModel> continents;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Center(
            child: Column(
          children: [
            Text(
              "Континенты",
              style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
            ),
            SizedBox(
              height: 20,
            ),
            ...widg,
            IsInSERT
                ? ElevatedButton(
                    onPressed: () async {
                      continents = await ContinentModel().getContinents();
                      setState(() {
                        for (var i in continents) {
                          widg.add(ContinentList(
                            id: i.id!,
                            dateCreate: i.dateCreate!,
                            title: i.title!,
                          ));
                        }
                        IsInSERT = false;
                      });
                    },
                    child: Text("Select"))
                : ElevatedButton(
                    onPressed: () async {
                      widg.clear();
                      continents = await ContinentModel().getContinents();
                      setState(() {
                        for (var i in continents) {
                          widg.add(ContinentList(
                            id: i.id!,
                            dateCreate: i.dateCreate!,
                            title: i.title!,
                          ));
                        }
                      });
                    },
                    child: Text("Обновить")),
            SizedBox(
              height: 20,
            ),
            Column(
              children: [
                Container(
                  child: TextFormField(
                    decoration:
                        ThemeHelper().textinputDecoration('id', 'Введите id'),
                    onChanged: (value) {
                      id = int.parse(value);
                    },
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                Container(
                  child: TextFormField(
                    onChanged: (value) {
                      title = value;
                    },
                    decoration: ThemeHelper()
                        .textinputDecoration('title', 'Введите title'),
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                Container(
                  child: TextFormField(
                    onChanged: (value) {
                      jsonData['ticks'] = int.parse(value);
                    },
                    decoration: ThemeHelper().textinputDecoration(
                        'date_create', 'Введите date_create'),
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                ElevatedButton(
                    onPressed: () {
                      setState(() async {
                        await ContinentModel()
                            .UpdateContinents(jsonData, id, title);
                      });
                    },
                    child: Text("Update")),
              ],
            ),
            SizedBox(
              height: 20,
            ),
            Column(
              children: [
                Container(
                  child: TextFormField(
                    decoration:
                        ThemeHelper().textinputDecoration('id', 'Введите id'),
                    onChanged: (value) {
                      id = int.parse(value);
                    },
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                ElevatedButton(
                    onPressed: () {
                      setState(() async {
                        await ContinentModel().DeleteContinents(id);
                      });
                    },
                    child: Text("delete")),
              ],
            ),
            SizedBox(
              height: 20,
            ),
            Column(
              children: [
                Container(
                  child: TextFormField(
                    onChanged: (value) {
                      title = value;
                    },
                    decoration: ThemeHelper()
                        .textinputDecoration('title', 'Введите title'),
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                Container(
                  child: TextFormField(
                    onChanged: (value) {
                      jsonData['ticks'] = int.parse(value);
                    },
                    decoration: ThemeHelper().textinputDecoration(
                        'date_create', 'Введите date_create'),
                  ),
                  decoration: ThemeHelper().inputBoxDecorationShaddow(),
                ),
                ElevatedButton(
                    onPressed: () {
                      setState(() async {
                        await ContinentModel()
                            .sendJsonGetContinents(jsonData, title);
                      });
                    },
                    child: Text("Insert")),
                ElevatedButton(
                    onPressed: () {
                      setState(() {
                        Navigator.pushReplacement(
                            context,
                            MaterialPageRoute(
                                builder: (context) => Country()));
                      });
                    },
                    child: Text("Страны")),
              ],
            ),
          ],
        )),
      ),
    );
  }
}
