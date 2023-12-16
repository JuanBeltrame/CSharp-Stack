using Stack_Practice_01;
using System.Drawing;

// Las colecciones en C# son objetos, por lo tanto ademas, sin tipos de referencia. 

// Forma 1: Declaracion y asignacion en una Linea sin valores iniciales
Stack<int> pila01 = new Stack<int>();

// Forma 2: Declaracion y asignacion en una linea sin valores iniciales con capacidad inicial especificada
Stack<int> pila02 = new Stack<int>(10);

// Forma 3: Declaracion e inicializacion en una sola linea con elementos
// Esta forma no se puede, o bien desconozoco como hacerlo

// Forma 4: Declaracion y asignacion en varias Lineas
Stack<int> pila04; 
pila04 = new Stack<int>();

// ---------------------------------------------------------------------------------------------------------
// Forma 1: Declarar Objetos // Declaracion y asignacion en una Linea sin valores iniciales
Stack<Auto> autoPila01 = new Stack<Auto>();

// Forma 2: Declarar Objetos // Declaracion y asignacion en una linea sin valores inciales con capacidad inicial especificada
Stack<Auto> autoPila02 = new Stack<Auto>(10);

// Forma 3: Declarar Objetos // Declaracion e inicializacion en una sola linea con elementos
Stack<Auto> autoPila03 = new Stack<Auto>(new Auto[] 
{ 
   new Auto(1, 12343, Color.AliceBlue, 1000), 
   new Auto(1, 12343, Color.AliceBlue, 1000), 
   new Auto(1, 12343, Color.AliceBlue, 1000) 
});

// Forma 4: Declarar Objetos // Delcaracion y asignacion en varias Lineas
Stack<Auto> autoPila04;
autoPila04 = new Stack<Auto>();
