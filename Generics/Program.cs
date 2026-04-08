Console.WriteLine("============================================================");
Console.WriteLine("GENERIC BOX<T> EXAMPLES");
Console.WriteLine("============================================================");

List<int> numbers = new List<int> { 100, 80, 40, 42, 64, 12, 4 };

Box<int> numberBox = new Box<int> {
    Name = "numberBox",
    Item = 8
};

numberBox.ItemList.AddRange(numbers);

Console.WriteLine("\nnumberBox:");
Console.WriteLine(numberBox);

Box<bool> boolBox = new Box<bool> {
    Name = "boolBox",
    Item = true
};

boolBox.ItemList.Add(false);
boolBox.ItemList.Add(true);
boolBox.ItemList.Add(false);

Console.WriteLine("\nboolBox:");
Console.WriteLine(boolBox);

Box<string> wordBox = new Box<string> {
    Name = "wordBox",
    Item = "Apple"
};

wordBox.ItemList.Add("Banana");
wordBox.ItemList.Add("Cherry");
wordBox.ItemList.Add("Dragonfruit");

Console.WriteLine("\nwordBox:");
Console.WriteLine(wordBox);


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("CREATING PHONE OBJECTS");
Console.WriteLine("============================================================");

iPhone iphoneA = new iPhone { Brand = "Apple", Model = "iPhone 16" };
iPhone iphoneB = new iPhone { Brand = "Apple", Model = "iPhone 15" };
iPhone iphoneC = new iPhone { Brand = "Apple", Model = "iPhone 14" };

List<iPhone> iphoneList = new List<iPhone> { iphoneA, iphoneB, iphoneC };

Android androidD = new Android { Brand = "Google", Model = "Android 12" };
Android androidE = new Android { Brand = "Samsung", Model = "Android 11" };
Android androidF = new Android { Brand = "Motorola", Model = "Android 10" };

List<Android> androidList = new List<Android> { androidD, androidE, androidF };

Console.WriteLine($"Created iPhone objects: {iphoneA.Model}, {iphoneB.Model}, {iphoneC.Model}");
Console.WriteLine($"Created Android objects: {androidD.Model}, {androidE.Model}, {androidF.Model}");


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("BOX<T> WITH iPhone");
Console.WriteLine("============================================================");

Box<iPhone> iphoneBox = new Box<iPhone> {
    Name = "iphoneBox",
    Item = iphoneA
};

iphoneBox.ItemList.AddRange(iphoneList);

Console.WriteLine("\niphoneBox:");
Console.WriteLine(iphoneBox);


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("BOX<T> WITH Android");
Console.WriteLine("============================================================");

Box<Android> androidBox = new Box<Android> {
    Name = "androidBox",
    Item = androidD
};

androidBox.ItemList.AddRange(androidList);

Console.WriteLine("\nandroidBox:");
Console.WriteLine(androidBox);


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("SMARTBOX<T> WITH Phone");
Console.WriteLine("============================================================");

SmartBox<Phone> mixedPhoneBox = new SmartBox<Phone> {
    Name = "mixedPhoneBox",
    Item = iphoneA
};

mixedPhoneBox.ItemList.Add(iphoneB);
mixedPhoneBox.ItemList.Add(androidD);
mixedPhoneBox.ItemList.Add(androidE);

Console.WriteLine("\nmixedPhoneBox:");
Console.WriteLine(mixedPhoneBox);

Console.WriteLine("Surfing the web on all phones in mixedPhoneBox:");
mixedPhoneBox.SurfWebOnList();

Console.WriteLine("\nUsing assistant command \"Check Weather\" on all phones in mixedPhoneBox:");
mixedPhoneBox.UseAssistantOnList("Check Weather");


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("SMARTBOX<T> WITH iPhone");
Console.WriteLine("============================================================");

SmartBox<iPhone> siriBox = new SmartBox<iPhone> {
    Name = "siriBox",
    Item = iphoneA
};

siriBox.ItemList.Add(iphoneB);
siriBox.ItemList.Add(iphoneC);

Console.WriteLine("\nsiriBox:");
Console.WriteLine(siriBox);

Console.WriteLine("Surfing the web on all iPhones in siriBox:");
siriBox.SurfWebOnList();

Console.WriteLine("\nUsing assistant command \"Hey Siri\" on all iPhones in siriBox:");
siriBox.UseAssistantOnList("Hey Siri");

Console.WriteLine("\nUsing assistant command \"Check Weather\" on all iPhones in siriBox:");
siriBox.UseAssistantOnList("Check Weather");


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("SMARTBOX<T> WITH Android");
Console.WriteLine("============================================================");

SmartBox<Android> googleBox = new SmartBox<Android> {
    Name = "googleBox",
    Item = androidD
};

googleBox.ItemList.Add(androidE);
googleBox.ItemList.Add(androidF);

Console.WriteLine("\ngoogleBox:");
Console.WriteLine(googleBox);

Console.WriteLine("Surfing the web on all Android phones in googleBox:");
googleBox.SurfWebOnList();

Console.WriteLine("\nUsing assistant command \"Ok Google\" on all Android phones in googleBox:");
googleBox.UseAssistantOnList("Ok Google");

Console.WriteLine("\nUsing assistant command \"Open Maps\" on all Android phones in googleBox:");
googleBox.UseAssistantOnList("Open Maps");


Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("WHY THE CONSTRAINT MATTERS");
Console.WriteLine("============================================================");

Console.WriteLine("Box<int> works because Box<T> accepts any type.");
Console.WriteLine("Box<string> works because Box<T> accepts any type.");
Console.WriteLine("Box<iPhone> works because Box<T> accepts any type.");
Console.WriteLine("SmartBox<iPhone> works because iPhone extends Phone.");
Console.WriteLine("SmartBox<Android> works because Android extends Phone.");
Console.WriteLine("SmartBox<Phone> works because Phone satisfies its own constraint.");

Console.WriteLine("\nThe following would NOT compile because int does not extend Phone:");
// SmartBox<int> badBox = new SmartBox<int> { Name = "badBox", Item = 5 };