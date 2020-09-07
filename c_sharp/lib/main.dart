import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: "ai-C-Sharp",
      home: Scaffold(
        body: Container(
          child: Center(
            child: RichText(
                text: TextSpan(
              children: [
                TextSpan(
                  text: "Learn C#",
                  style: TextStyle(
                    color: Colors.blue,
                    fontSize: 50.0,
                  ),
                ),
                TextSpan(
                  text: "\n   Basic to Advance",
                  style: TextStyle(
                    color: Colors.blueGrey,
                    fontSize: 20.0,
                  ),
                ),
              ],
            )),
          ),
        ),
      ),
    );
  }
}
