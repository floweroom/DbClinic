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
    // db.Database.EnsureCreated();
    db.Database.Migrate();

    Person person = new Person();
   // person.Id = 01;
    person.Name = "Жгутов Анатолий Иванович";
    person.Age = 30;
    person.PersonalData = "Родился в городе Владивостоке, курит, работает на заводе";
    person.AnamnesisDesise = "Обратился с болью в области сердца";
    person.AnamnesisLife = "Аллергия на пыль; болел туберкулезом";
    person.ObjectStatus = false;
    person.PlanSurvey = "Анализ крови; биохимия, посев мокроты";
    person.PlanTherapy = "Диета";
    

    Person person1 = new Person();
    //person1.Id = 02;
    person1.Name = "Камнеежкина Антонона Петровна";
    person1.Age = 43;
    person1.PersonalData = "Родилась в городе Владивостоке, курит, работает в театре";
    person1.AnamnesisDesise = "Обратился с болью в области головы";
    person1.AnamnesisLife = "Аллергия на пыль; не болел туберкулезом, есть биполярное растройство личности";
    person1.ObjectStatus = true;
    person1.PlanSurvey = "Анализ крови; биохимия, ЭКГ";
    person1.PlanTherapy = "Трепанация черепа";
 

    Person person2 = new Person();
    //person2.Id = 03;
    person2.Name = "Воробьева Анна Михайловна";
    person2.Age = 27;
    person2.PersonalData = "Родилась в городе Владивостоке, домохозяйка";
    person2.AnamnesisDesise = "Обратился с нарушением менструального цикла";
    person2.AnamnesisLife = "Аллергия отсутствует; не болел туберкулезом";
    person2.ObjectStatus = true;
    person2.PlanSurvey = "Анализ крови; биохимия";
    person2.PlanTherapy = "Обследование";
   

    db.Persons.Add(person);
    db.Persons.Add(person1);
    db.Persons.Add(person2);
    db.SaveChanges();

}

