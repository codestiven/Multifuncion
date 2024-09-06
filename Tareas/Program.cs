using System;
using System.Text;

namespace Todo { 
public class Comienzo
{ 
 static void Main(string[] args)
{ 



        Inicio();
}

public static void Inicio()
    {
            bool sentenciador = true;

            while (sentenciador == true)
            {

                Console.Clear();






                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"

::::::::::: ::::::::::: :::            :::     
    :+:         :+:     :+:          :+: :+:   
    +:+         +:+     +:+         +:+   +:+  
    +#+         +#+     +#+        +#++:++#++: 
    +#+         +#+     +#+        +#+     +#+ 
    #+#         #+#     #+#        #+#     #+# 
###########     ###     ########## ###     ### 


");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Elige una opción");

                Console.WriteLine(@"

1) Acerca de
2) Algoritmos
3) Sumadora
4) Salir

");

                Console.Write("cual desea tomar : ");
                string entrada = Console.ReadLine() ?? "";


                if (entrada == "1")
                {
                    SobreMi.Sobre_mi();
                }
                else if (entrada == "2")
                {
                    Algoritmos.Principal();

                }
                else if (entrada == "3")
                {
                    Algoritmos.Calculadora();
                }
                else if (entrada == "4")
                {

                    sentenciador = false;
                };
            }


        }
    }
}

