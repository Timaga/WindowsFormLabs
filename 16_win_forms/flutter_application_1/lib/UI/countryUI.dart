import 'dart:convert';
import 'dart:io';
import 'dart:typed_data';
import 'package:file_selector/file_selector.dart';
import 'package:flutter_application_1/UI/continentUI.dart';
import 'package:image_picker/image_picker.dart';
import 'package:image_picker_platform_interface/image_picker_platform_interface.dart';
import 'package:flutter/material.dart';
import 'package:flutter_application_1/UI/designe/list_country.dart';
import 'package:flutter_application_1/UI/designe/list_designe.dart';
import 'package:flutter_application_1/UI/designe/theme_helper.dart';
import 'package:flutter_application_1/repos/continent_repos.dart';
import 'package:flutter_application_1/repos/country_repos.dart';
import 'package:image_picker_web/image_picker_web.dart';

class Country extends StatefulWidget {
  const Country({super.key});

  @override
  State<Country> createState() => _CountryState();
}

var jsonData = {"ticks": 30};

class _CountryState extends State<Country> {
  ImagePicker picker = ImagePicker();
  List<String> items = [];
  List<int> id_items = [];
  List<Widget> widg = [];
  int id = 1;
  String title = "";
  late File img;
  String capital = "";
  var byte;
  Map<String, int> combinedMap = {};
  late File file;
  bool IsChoose = false;
  bool iScHOOSE2 = false;
  var imageFile;
  int id_cont = 0;
  var btw;
  String selectedValue = " ";
  bool IsInSERT = true;
  bool isDropdownOpen = false;
  bool isDropdownOpen2 = false;
  late List<ContinentModel> continents2;
  late List<CountryModel> continents;
  @override
  Widget build(BuildContext context) {
    //   if (IsChoose == true)
    //  final btw= base64Decode(byte.toString());
    // if (IsInSERT == false) selectedValue = items.first;
    return Scaffold(
      body: SingleChildScrollView(
        child: Center(
            child: Column(
          children: [
            Text(
              "Страны",
              style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
            ),
            SizedBox(
              height: 20,
            ),
            ...widg,
            IsInSERT
                ? ElevatedButton(
                    onPressed: () async {
                      continents = await CountryModel().getCountry();
                      continents2 = await ContinentModel().getContinents();
                      for (var j in continents2) {
                        items.add(j.title!);
                        id_items.add(j.id!);
                      }
                      for (int i = 0; i < items.length; i++) {
                        combinedMap[items[i]] = id_items[i];
                      }
                      int j = 1;
                      setState(() {
                        for (var i in continents) {
                          final bytes = base64Decode(i.photo!);
                          final image = Image.memory(bytes);
                          widg.add(CountryList(
                            id: i.id!,
                            title: i.title!,
                            name: combinedMap.keys.toList().elementAt(j),
                            photo: image!,
                            Capital: i.capital!,
                          ));
                          j++;
                        }
                        IsInSERT = false;
                      });
                    },
                    child: Text("Select"))
                : ElevatedButton(
                    onPressed: () async {
                      widg.clear();
                      continents = await CountryModel().getCountry();
                      continents2 = await ContinentModel().getContinents();
                      for (var j in continents2) {
                        items.add(j.title!);
                        id_items.add(j.id!);
                      }
                      for (int i = 0; i < items.length; i++) {
                        combinedMap[items[i]] = id_items[i];
                      }
                      int j = 1;
                      setState(() {
                        for (var i in continents) {
                          final bytes = base64Decode(i.photo!);
                          final image = Image.memory(bytes);
                          widg.add(CountryList(
                            id: i.id!,
                            title: i.title!,
                            name: combinedMap.keys.toList().elementAt(j),
                            photo: image!,
                            Capital: i.capital!,
                          ));
                          j++;
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
                      capital = value;
                    },
                    decoration: ThemeHelper()
                        .textinputDecoration('capital', 'Введите capital'),
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
                SizedBox(
                  height: 10,
                ),
                GestureDetector(
                  onTap: () {
                    setState(() {
                      isDropdownOpen = !isDropdownOpen;
                    });
                  },
                  child: Column(
                    children: [
                      Container(
                        padding:
                            EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                        decoration: BoxDecoration(
                          border: Border.all(color: Colors.grey),
                          borderRadius: BorderRadius.circular(4),
                        ),
                        child: Row(
                          children: [
                            Expanded(
                              child: Text(
                                selectedValue.isEmpty
                                    ? 'Выберите элемент'
                                    : selectedValue,
                                style: TextStyle(fontSize: 16),
                              ),
                            ),
                            Icon(isDropdownOpen
                                ? Icons.arrow_drop_up
                                : Icons.arrow_drop_down),
                          ],
                        ),
                      ),
                      if (isDropdownOpen)
                        Container(
                          height: 200, // Высота выпадающего списка
                          decoration: BoxDecoration(
                            border: Border.all(color: Colors.grey),
                            borderRadius: BorderRadius.circular(4),
                          ),
                          child: ListView.builder(
                            itemCount: combinedMap.keys.toList().length,
                            itemBuilder: (context, index) {
                              return GestureDetector(
                                onTap: () {
                                  setState(() {
                                    selectedValue =
                                        combinedMap.keys.toList()[index];
                                    id_cont =
                                        combinedMap.values.toList()[index];
                                    isDropdownOpen = false;
                                  });
                                },
                                child: ListTile(
                                  title: Text(combinedMap.keys.toList()[index]),
                                ),
                              );
                            },
                          ),
                        ),
                    ],
                  ),
                ),
                SizedBox(
                  height: 10,
                ),
                ElevatedButton(
                    onPressed: () async {
                      const XTypeGroup typeGroup = XTypeGroup(
                        label: 'images',
                        extensions: <String>['jpg', 'png'],
                      );
                      final XFile? file = await openFile(
                          acceptedTypeGroups: <XTypeGroup>[typeGroup]);

                      byte = file;
                      setState(() {
                        IsChoose = true;
                      });
                    },
                    child: Text("Pick")),
                IsChoose ? Text("Выбрана картинка") : Container(),
                ElevatedButton(
                    onPressed: () async {
                      await CountryModel()
                          .updateCountry(byte, id, title, capital, id_cont);
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
                        await CountryModel().DeleteCountry(id);
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
                      capital = value;
                    },
                    decoration: ThemeHelper()
                        .textinputDecoration('capital', 'Введите capital'),
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
                GestureDetector(
                  onTap: () {
                    setState(() {
                      isDropdownOpen2 = !isDropdownOpen2;
                    });
                  },
                  child: Column(
                    children: [
                      Container(
                        padding:
                            EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                        decoration: BoxDecoration(
                          border: Border.all(color: Colors.grey),
                          borderRadius: BorderRadius.circular(4),
                        ),
                        child: Row(
                          children: [
                            Expanded(
                              child: Text(
                                selectedValue.isEmpty
                                    ? 'Выберите элемент'
                                    : selectedValue,
                                style: TextStyle(fontSize: 16),
                              ),
                            ),
                            Icon(isDropdownOpen2
                                ? Icons.arrow_drop_up
                                : Icons.arrow_drop_down),
                          ],
                        ),
                      ),
                      if (isDropdownOpen2)
                        Container(
                          height: 200, // Высота выпадающего списка
                          decoration: BoxDecoration(
                            border: Border.all(color: Colors.grey),
                            borderRadius: BorderRadius.circular(4),
                          ),
                          child: ListView.builder(
                            itemCount: combinedMap.keys.toList().length,
                            itemBuilder: (context, index) {
                              return GestureDetector(
                                onTap: () {
                                  setState(() {
                                    selectedValue =
                                        combinedMap.keys.toList()[index];
                                    id_cont =
                                        combinedMap.values.toList()[index];
                                    isDropdownOpen2 = false;
                                  });
                                },
                                child: ListTile(
                                  title: Text(combinedMap.keys.toList()[index]),
                                ),
                              );
                            },
                          ),
                        ),
                    ],
                  ),
                ),
                ElevatedButton(
                    onPressed: () async {
                      const XTypeGroup typeGroup = XTypeGroup(
                        label: 'images',
                        extensions: <String>['jpg', 'png'],
                      );
                      final XFile? file = await openFile(
                          acceptedTypeGroups: <XTypeGroup>[typeGroup]);

                      imageFile = file;
                      setState(() {
                        iScHOOSE2 = true;
                      });
                    },
                    child: Text("Pick")),
                SizedBox(
                  height: 20,
                ),
                iScHOOSE2 ? Text("Выбрана картинка") : Container(),
                SizedBox(
                  height: 20,
                ),
                ElevatedButton(
                    onPressed: () {
                      setState(() async {
                        await CountryModel().sendJsonGetCountry(
                            imageFile, title, capital, id_cont);
                      });
                    },
                    child: Text("Insert")),
                SizedBox(
                  height: 20,
                ),
                ElevatedButton(
                    onPressed: () {
                      setState(() {
                        Navigator.pushReplacement(
                            context,
                            MaterialPageRoute(
                                builder: (context) => Continent()));
                      });
                    },
                    child: Text("континенты")),
              ],
            ),
          ],
        )),
      ),
    );
  }
}
