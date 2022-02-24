using Interfejsi;

List<Osoba> o = new();
o.Add(new Radnik());
o.Add(new Student());

List<Figura> f = new();
f.Add(new Pravougaonik());
f.Add(new Kvadrat());

List<IIspis> ispis = new();
ispis.Add(new Radnik());
ispis.Add(new Student());
ispis.Add(new Pravougaonik());
ispis.Add(new Kvadrat());

ispis.ForEach(i => i.Ispis());