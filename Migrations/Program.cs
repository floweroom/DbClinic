using DbClinic.DataBase;
using Microsoft.EntityFrameworkCore;

var Builder = new DbContextOptionsBuilder<PersonDb>();
Builder.UseSqlServer("Server=(localDB)\\MSSQLLOCALDB;DATABASE=TestDB1");


var options = new DbContextOptionsBuilder<PersonDb>()
    .UseSqlServer("Server=(localDB)\\MSSQLLOCALDB;DATABASE=TestDB1")
    .Options;



using (var db = new PersonDb(options))
{
    //db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    db.Database.Migrate();

    Person person = new Person();
    person.Id = 01;
    person.Name = "Жгутов Анатолий Иванович";
    person.Age = 30;
    person.PersonalData = "Родился в городе Владивостоке, курит, работает на заводе";
    person.AnamnesisDesise = "Обратился с болью в области сердца";
    person.AnamnesisLife = "Аллергия на пыль; болел туберкулезом";
    person.ObjectStatus = false;
    person.PlanSurvey = "Анализ крови,биохимия, посев мокроты";
    person.PlanTherapy = "Диета";

    Person person1 = new Person();
    person.Id = 02;
    person.Name = "Камнеежкина Антонона Петровна";
    person.Age = 43;
    person.PersonalData = "Родилась в городе Владивостоке, курит, работает в театре";
    person.AnamnesisDesise = "Обратился с болью в области головы";
    person.AnamnesisLife = "Аллергия на пыль; не болел туберкулезом, есть биполярное растройство личности";
    person.ObjectStatus = true;
    person.PlanSurvey = "Анализ крови,биохимия, ЭКГ";
    person.PlanTherapy = "Трепанация черепа";

    Person person2 = new Person();
    person.Id = 03;
    person.Name = "Воробьева Анна Михайловна";
    person.Age = 27;
    person.PersonalData = "Родилась в городе Владивостоке, домохозяйка";
    person.AnamnesisDesise = "Обратился с нарушением менструального цикла";
    person.AnamnesisLife = "Аллергия отсутствует; не болел туберкулезом";
    person.ObjectStatus = true;
    person.PlanSurvey = "Анализ крови,биохимия, ЭКГ";
    person.PlanTherapy = "Обследование";

    db.Persons.Add(person);
    db.Persons.Add(person1);
    db.Persons.Add(person2);
    db.SaveChanges();

}

