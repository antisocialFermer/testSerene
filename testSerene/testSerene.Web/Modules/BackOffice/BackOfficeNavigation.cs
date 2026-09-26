using backOffice = testSerene.Modules.BackOffice;

[assembly: NavigationMenu(9000, "BackOffice", icon: "fa-tag")]
[assembly: NavigationLink(9100, "BackOffice/Tariffs", typeof(backOffice.Tariffs.TariffsPage), icon: "fa-comments")]

