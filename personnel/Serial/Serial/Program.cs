Actor thomas = new Actor
{
    FirstName = "Thomas",
    LastName = "Nardou",
    BirthDate = new DateTime(2006, 04, 19),
    Country = "Papouasie",
    IsAlive = true,
};

Character bob = new Character
{
    FirstName = "Bob",
    LastName = "Alaise",
    Description = "Personne pas très intelligent mais avec beaucoup de chance",
    PlayedBy = thomas
};

Episode laMortDeBob = new Episode
{
    Title = "Bob est mort ???",
    DurationMinutes = 30000,
    SequenceNumber = 1051450,
    Director = "Le voisin",
    Synopsis = "Alors que Bob joue comme d'habitude à LoL, il va tomber sur une chose extrement rare et dangereuse qui se ferait appeler 'doûsche'...",
    Characters = {bob}
};


Serie roadToMaster = new Serie();