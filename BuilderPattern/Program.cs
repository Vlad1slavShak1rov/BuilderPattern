using BuilderPattern;

var builder = new BuilderPC();
var director = new DirectorPC(builder);

Motherboard motherboard = new("Asus");
Processor processor = new("Intel Core 2 QUAD Q9400");
RAM ram = new("DDR4 32GB");
Storage storage = new("SSD 512");
GraphicCards card = new("RTX 9999 512GB");
director.Build(processor, motherboard, ram, storage, card);

var result = builder.GetComputer();

Console.WriteLine($"Материнская плата: {result.Motherboard}\n"
    +$"Процессор {result.Processor}\n"+
    $"Оперативная память: {result.RAM}\n" +
    $"Накопитель: {result.Storage}\n"+
    $"Графический адаптер: {result.GCard}");