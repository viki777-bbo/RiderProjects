string data = "JMENO=Karel,VEK=45,MESTO=Praha";
string[] hodnoty = data.Split(',', '=');
Console.WriteLine($"{hodnoty[1]} {hodnoty[3]} {hodnoty[5]}");