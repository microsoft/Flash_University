// See https://aka.ms/new-console-template for more information

using ResidencyPager;

ResidencyPagerManager DrKelso = new ResidencyPagerManager();
Console.WriteLine("So it begins");

DrKelso.GeneratePage("Kelso", "Dorian", "Where is Scooter");

Console.WriteLine("Oh, I'm incompetent, let me add him to the list");

Pager pager = new Pager(DrKelso);

DrKelso.GeneratePage("Kelso", "Dorian", "Where is Scooter");

Console.WriteLine("Oh, he didn't respond. Let's add his email");

Email email = new Email(DrKelso);

DrKelso.GeneratePage("Kelso", "Dorian", "Your Patient is coding...");

Phone phone = new Phone(DrKelso);

DrKelso.GeneratePage("Kelso", "Dorian", "Turk is calling...");

Console.WriteLine("There we go... we just need to call him.... he doesn't listen to anything else");

pager.Unregister(DrKelso);
email.Unregister(DrKelso);


DrKelso.GeneratePage("Kelso", "Dorian", "I know you're listening");

Console.WriteLine("Does Order matter?");

Console.WriteLine("Before it was  pager, email, phone-- unregistered pager and email, so now just phone");

email.Register(DrKelso);

DrKelso.GeneratePage("Kelso", "Turk", "You're up for surgery.... stop sleeping -- note this came out as phone -email");
