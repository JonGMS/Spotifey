
using System.Reflection.Metadata;
using System.Security.Authentication.ExtendedProtection;
bool service = false;
do
{
    while (!service)
    {
        Menu.ApresentarTitulo(" - Tela Inicial");

        service = Menu.Login();
    }

    Menu.TelaInicial();



} while (service);


