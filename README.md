# Frukt – Programavimo Kalba

## Komanda: Rimti Fruktai
- Emilis Kasiulynas IFF-1/5  
- Laimis Černiauskas IFF-1/5  
- Mildaras Karvelis IFF-1/4  

## Kalbos idėja
Lengvai skaitoma ir patogiai rašoma programavimo kalba. Tikslas – mažiau mašininio pobūdžio sintaksės, intuityvūs konstruktai.

## Kalbos savybės
- Lengvai skaitomas ir rašomas kodas
- Automatinis duomenų tipo atpažinimas

### Palaikomos struktūros:
- Masyvai (`Array[]`)

### Duomenų tipai:
- `Character`, `Text`, `Number`, `Expression`

## Baziniai pavyzdžiai

```frukt
While A != 2 {
   Print(A).
}

If 10 >= 5 {
   10 * 5.
} else 10 < 5 {
   10 / 2.
}

Text = "vaisiai yra sveika vartoti žmogaus organizmui".
Number = 10.4
Symbol = "a"
Expression = true/false.
Array = [1, 2.3, 3, true, "Tekstas", "#"].
Print("Sveikas, apelsine!").
PrintTo("failas.txt", argumentas).
```

## Unikali savybė
Paprastas dvigubas palyginimas:
```frukt
If(-3 < n < 5)
```
vietoje įprasto:
```frukt
If(-3 < n && n < 5)
```

## Naudoti įrankiai
- **Visual Studio Code** – dėl patirties ir priedų.
- **ANTLR4** – lengvas lexer ir parser scriptų generavimas.
- **Programavimo kalba** – C#.

## Gramatika (ANTLR4)
[Spustelėkite, norėdami matyti gramatiką](./grammar/Frukt.g4)

## Kompiliavimas ir paleidimas

1. Parašykite `.frkt` failą
2. Kompiliuokite per VS Code (atsiras `Frukt.exe`)
3. Vykdymas per komandų eilutę:
```sh
cd Frukt\bin\Debug\net7.0
start cmd /k ".\Frukt.exe .\sample.frkt"
```

## Pavyzdinis kodas

```frukt
PrintTo("output.txt", "Printinu", "i faila").

Fibonacci(limit, number1, number2)
{   
    if number1 + number2 > limit {
        Print("done").
        PrintTo("fibonacci.txt", "done").
    } else {
        number12 = number1 + number2.
        Print(number12).
        PrintTo("fibonacci.txt", number12).
        number1 = number2.
        number2 = number12.
        Fibonacci(limit, number1, number2).    
    }
}

Fibonacci(10, 1, 1).
Print("Sveikas, apelsine!").
```

## Šaltiniai
- [YouTube – ANTLR pamoka](https://www.youtube.com/watch?v=bfiAvWZWnDA)
- [GitHub – P175B124](https://github.com/P175B124)
