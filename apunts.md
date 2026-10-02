# Crar document

## Crea documet amb el ```Hello world```

```c#
dotnet new console -o <nom>
```

## Estructura

``` c#
Class Program{
    static void Main(strin[] args){

    }
}
```

## Guardar  dades

``` c#
- var = cualquiera
- void = res
- bool = si o no
- Numeros
    - int = numero enter
    - long = numero enter i llarc
    - float = numero amb decimals
    - double = numero amb decimals
- Text 
    - char = caracter
    - string = paraula/frase
```

## Bucles

### for

```c#
var nom ="Filomeno";
var llargada = nom.Length;

for (var i=0;i<LLargada;i++)
{Console.Writ(nom[i])}
```

### foreach

```c#
var nom ="Filomeno";

foreach (var lletra in nom){
    Console.Writ(lletra)
}
```

### while

```c#
int index=0;

while (index<llargada){
    Console.Writ(nom[index])
    index++;
}
```
