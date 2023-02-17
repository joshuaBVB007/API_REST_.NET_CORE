/*
    Este es el modelo: sobre los datos de esta clase nuetra API va trabajar,todos los JSON
    que insertemos en POSTMAN tendran estas 3 propiedades
*/

public class Todo{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}