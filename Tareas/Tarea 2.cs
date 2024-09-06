using System;
using System.Text;

public class Algoritmos
{
	public static void Principal()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Clear();
		Console.WriteLine(@"

   ____________________________________________________
  |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____|
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |



1) Llegar de tu casa a bahía de las Aguilas
2) Preparar un sancocho
3) Como aprender a montar bicicleta
4) Sumar 2 números.
5) Como cambiar el aceite de un vehículo de motor.
6) Llegar a ser senador en de RD.
7) Como desarrollar un algoritmo.
8) Como llegar al itla desde tu casa.
9) Como preparar una yaroa de papas con pollo. 
10) Comprar una laptop en internet.
11) volver atras

");
		bool entro = true;
        while (entro == true) { 
		Console.Write("cual desea tomar : ");
		string entrada = Console.ReadLine() ?? "";


		if (entrada == "1")
		{
			Algoritmos_1();
			Principal();
		}
		else if (entrada == "2")
		{
			Algoritmos_2();
			Principal();
		}
		else if (entrada == "3")
		{
			Algoritmos_3();
			Principal();

		}
		else if (entrada == "4")
		{
			Algoritmos_4();
			Principal();

		}
		else if (entrada == "5")
		{
			Algoritmos_5();
			Principal();

		}
		else if (entrada == "6")
		{
			Algoritmos_6();
			Principal();

		}
		else if (entrada == "7")
		{
			Algoritmos_7();
			Principal();
		}
		else if (entrada == "8")
		{
			Algoritmos_8();
			Principal();
		}
		else if (entrada == "9")
		{
			Algoritmos_9();
			Principal();
		}
		else if (entrada == "10")
		{
			Algoritmos_10();
			Principal();
		}
		else if (entrada == "11")
		{

				entro = false;

			}
		else
		{
			
		}
			entro = false;
		};

	}
	public static void Algoritmos_1()
	{  
		Console.Clear();
		ConsoleColor original = Console.ForegroundColor;


		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(@"

_\/_                 |                _\/_
/o\\             \       /            //o\
 |                 .---.                |
_|_______     --  /     \  --     ______|__
         `~^~^~^~^~^~^~^~^~^~^~^~`

");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("COMO Llegar de san cristobal a bahía de las Aguilas");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.ReadKey();

		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("1 - salga de su casa");
		Console.ReadKey();
		Console.WriteLine(@"");
		Console.WriteLine(" 2 - diríjase en camino a la parada del trasporte más cercano de su ubicación actual si conoce su ubicación");
		Console.ReadKey();
		Console.WriteLine(@"");
		Console.WriteLine(" 3 - siéntese esperar en la zona del trasporte público");
		Console.ReadKey();
		Console.WriteLine(@"");
		Console.WriteLine(" 4 - Cuando llegue el autobús público adecuado que en mi caso sería la B la tomo para dirigirme al destino");
		Console.ReadKey();

//inicio de animacion

		Console.Clear();
		Thread.Sleep(500);
		Console.WriteLine(@"
 _________________________   
|   |     |     |    | |  \  
|___|_____|_____|____|_|___\ 
|                    | |    \
`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
	 _________________________   
	|   |     |     |    | |  \  
	|___|_____|_____|____|_|___\ 
	|                    | |    \
	`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
		 _________________________   
		|   |     |     |    | |  \  
		|___|_____|_____|____|_|___\ 
		|                    | |    \
		`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
			 _________________________   
			|   |     |     |    | |  \  
			|___|_____|_____|____|_|___\ 
			|                    | |    \
			`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````

"); Thread.Sleep(500);


		Console.Clear();
		Console.WriteLine(@"
				 _________________________   
				|   |     |     |    | |  \  
				|___|_____|_____|____|_|___\ 
				|                    | |    \
				`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
					 _________________________   
					|   |     |     |    | |  \  
					|___|_____|_____|____|_|___\ 
					|                    | |    \
					`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);

		Console.WriteLine("");
		Console.WriteLine(" 4 - debido a la limitación del trasporte sancristobalense deténgase en azua ");
		Console.ReadKey();

		Console.WriteLine("");
		Console.WriteLine(" 5 - En pedernales tomé otro trasporte que le lleve directamente al objetivo");
		Console.ReadKey();

		Console.Clear();
		Thread.Sleep(200);
		Console.WriteLine(@"
 _________________________   
|   |     |     |    | |  \  
|___|_____|_____|____|_|___\ 
|                    | |    \
`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
	 _________________________   
	|   |     |     |    | |  \  
	|___|_____|_____|____|_|___\ 
	|                    | |    \
	`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
		 _________________________   
		|   |     |     |    | |  \  
		|___|_____|_____|____|_|___\ 
		|                    | |    \
		`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
			 _________________________   
			|   |     |     |    | |  \  
			|___|_____|_____|____|_|___\ 
			|                    | |    \
			`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````

"); Thread.Sleep(200);


		Console.Clear();
		Console.WriteLine(@"
				 _________________________   
				|   |     |     |    | |  \  
				|___|_____|_____|____|_|___\ 
				|                    | |    \
				`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
					 _________________________   
					|   |     |     |    | |  \  
					|___|_____|_____|____|_|___\ 
					|                    | |    \
					`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(500);
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(@"

_\/_                 |                _\/_
/o\\             \       /            //o\

 |                 .---.                |
_|_______     --  /     \  --     ______|__
         `~^~^~^~^~^~^~^~^~^~^~^~`


");
		Console.WriteLine("");
		Console.WriteLine("Y ya está en bahía de las Águilas");
		Thread.Sleep(4000);
		Console.WriteLine("FIN");
		Console.ReadKey();
		Principal();
	}
	public static void Algoritmos_2() {
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Clear();
		Console.WriteLine(@"                  
██                                                                        ▒▒▒▒▓▓                
██                                                                    ████      ██▓▓            
██                                                                  ██      ░░░░██▓▓            
██                                                                ██      ░░████                
██                                                              ▓▓    ░░▓▓██                    
██                                  ▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓  ░░  ▓▓                        
██                            ██████                        ░░      ██                          
██                        ▓▓▓▓      ░░                          ░░  ▒▒████                      
██                      ██    ░░                              ░░    ░░    ██                    
██                    ▓▓  ░░▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ░░▒▒▒▒    ▒▒░░  ▓▓                  
██                    ██  ░░▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ░░▒▒▒▒    ▒▒░░  ██                  
██                  ██  ░░▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒  ▒▒▒▒    ░░▒▒  ▒▒▒▒▒▒  ▒▒░░  ██                
██                  ██  ▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒  ▒▒▒▒    ░░▒▒  ▒▒  ▒▒▒▒▒▒  ▒▒  ██                
██                  ██  ▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒            ▒▒▒▒  ▒▒▒▒▒▒  ▒▒  ██                
██                  ██  ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒░░  ██                
██                  ██    ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                ▒▒▒▒▒▒▒▒▒▒░░    ██                
██                  ██      ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ██                
██                  ██▓▓            ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░              ██                
██                  ██▒▒                            ░░░░░░              ░░    ██                
██                  ██▓▓  ▒▒▒▒                                        ▒▒▒▒    ██                
██                  ██  ▒▒  ▒▒▒▒                                  ░░▒▒▒▒░░    ██                
██                  ██░░      ▒▒      ▒▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒▒    ░░▒▒░░      ██                
██                    ██      ▒▒    ▒▒▒▒░░░░▒▒▒▒    ▒▒▒▒░░░░▒▒▒▒    ▒▒      ▓▓                  
██                    ██        ▓▓▒▒▒▒        ▒▒▓▓▓▓▒▒        ▒▒▒▒▓▓        ██                  
██                    ██░░                                    ░░░░░░░░    ░░██                  
██                      ▓▓                                    ░░      ░░  ▓▓                    
██                      ██░░                                            ░░██                    
██                      ░░▓▓░░                                        ░░▓▓░░                    
██                          ▓▓░░                            ░░      ░░▓▓░░                      
██                            ████░░                  ░░        ░░████                          
██                                ██▓▓▓▓░░░░            ░░░░▓▓▓▓██                              
██                                    ░░▓▓██░░▓▓██▓▓████████                                    
██                                        ░░▒▒░░░░░░░░░░░░░░                                    
");
		Console.WriteLine("Como Preparar un sancocho");
		Console.WriteLine("");
		Console.ReadKey();
		Console.WriteLine("buscar los contenidos nesesarios para elaborar la preparacion ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(@"

 __       ___,.-------..__        __
//\\ _,-''                `'--._ //\\
\\ ;'                           `: //
 `(                               )'
   :.                           ,;
    `.`--.___           ___.--','
      `.     ``-------''     ,'
         -.               ,-
      gpyy  `-._______.-'
");
		Console.WriteLine(" 1 - En una olla lleva al fuego el aceite hasta calentar");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 2 - sofríe las carnes por 5 minutos");
		Console.ReadKey();
		Console.WriteLine("5");
		Thread.Sleep(500);
		Console.WriteLine("4");
		Thread.Sleep(500);
		Console.WriteLine("3");
		Thread.Sleep(500);
		Console.WriteLine("2");
		Thread.Sleep(500);
		Console.WriteLine("1");

		Console.WriteLine("");
		Console.WriteLine(" 3 - agrega la mitad de la auyama");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(@"
        (
          )
     __..---..__
 ,-='  /  |  \  `=-.
:--..___________..--;
 \.,_____________,./
");
		Console.WriteLine(" 4 - tapa y cocina hasta que las carnes estén blandas ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 5 - tapa y cocina hasta que las carnes estén blandas ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("6 - Pasado el tiempo, retira las carnes de la olla, y guadalas para mas adelante ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 7 - En la misma olla, añade la longaniza y el agua");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 8 - cuando rompa el hervor, agrega los víveres y el resto de la auyama.");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 9 - Deja cocinar por 10 minutos más");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 10 - pasado el tiempo, incorpora las carnes el ají, el atado de verduras, el agrio naranja");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(" 11 - cocina por 10 minutos más o hasta obtener la consistencia deseada.retira del fuego y sirve.");
		Console.WriteLine("10");
		Thread.Sleep(100);
		Console.WriteLine("9");
		Thread.Sleep(100);
		Console.WriteLine("8");
		Thread.Sleep(100);
		Console.WriteLine("7");
		Thread.Sleep(100);
		Console.WriteLine("6");
		Thread.Sleep(100);
		Console.WriteLine("5");
		Thread.Sleep(100);
		Console.WriteLine("4");
		Thread.Sleep(100);
		Console.WriteLine("3");
		Thread.Sleep(100);
		Console.WriteLine("2");
		Thread.Sleep(100);
		Console.WriteLine("1");
		Console.ReadKey();


		Console.WriteLine(@"
           __
          //\\  .-""""""""-.
          \\// (o0OoO0oOoOoo)
           ||  |`""""""""""`|
           ||  \            /
           ||   '.________.'
           ||
");
		Console.WriteLine("Fin");
		Console.ReadKey();
	}
	public static void Algoritmos_3()
	{
		Console.Clear();
		Console.WriteLine(@"
 -------- __@      __@       __@       __@      __~@
 ----- _`\<,_    _`\<,_    _`\<,_     _`\<,_    _`\<,_
 ---- (*)/ (*)  (*)/ (*)  (*)/ (*)  (*)/ (*)  (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

");
		Console.WriteLine("1 - Como aprender a montar bicicleta");
		Console.WriteLine("");
		Console.ReadKey();
		Console.WriteLine("2 - Primero consigue una bicicleta cómoda y que se adapte a tu filosofía y preferentemente con ruedas ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("3 - Se sube en ella aun sin subir las piernas");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("4 - Sele otorga una acción de impulso a la bicicleta");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("5 - Luego de un buen impulso se suben la pierna");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("6 - Se coloca los pies en los pedales correspondientes a su lado ");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine(@"
7 - Se le aplica una fuerza inversa en cada pie para que el pedal realice un movimiento circular
para aplicar movimiento a las cadenas que su vez trasmite dicho movimiento circular a las llantas traseras
");
		Console.ReadKey();
		Console.WriteLine("");
		Console.ReadKey();
		Console.WriteLine(@"


                                                      __
                                                    .'  `.
                                                   /      \
                     o                            /        |
                      8ooooooooo               __________  |
                        ``8'                  /.-------. \ |
                         |`                   ||      ` ` |<
                          `|___________________\\      |||| )
                          / _____________________\ ._._.'.'(
                         / |                     \\ ``--'
                        //|`                      \\
                       //  `|                      \\
                      //   |`                      . \
         .d888888b.  //     `|                   .'.'\\  .d888888b.
      o8Y'   .    `Y//      |`                  / /   \\Y'    .  .`Y8o
    oY'   .  .   . //Y8o     `|               .'.'  dY'\\  .  .     .`Yo
   dY  .     .    //   Yb    |`              / /   dY.  \\    .    .  .Yb
  dY .  .  . .  .//   . Yb    `|           .'.'   dY   . \\ . . . .     Yb
 oY.   . .   .  //  .    Yb   |`          / /    oY .    .\\  .  . .   . Yo
o8    .   .  . // .    .  8b   `| =.=   .'.'    o8     .   \\ . .   .     8o
8Y  .    . . .//__________Y8___|`_____ / /      8P  .     . \\.. .     .  Y8
8............@/__ ........ 8   .'.  ..`.'       8............\@)...........8
8    .   . (`-.__`--.__   d8  /. . |..  \       8     .  .  . . . .     .  8
8b    .    .(@   `--.__`--.__|....  .... |      8b.    .   .  .  .   .    d8
Y8 .    . .  `-._      `--.__|..   @     |      Y8   .  . . . . . . .  .  8Y
 Yb   .  .   .  .`-._   dP   |.... |.    |       Yb.     .    .    .     dP
  Yb.   .  . . . .   `-dP     \  . |... /         Yb .  .  .  .  .  .  .dP
   Yo. .     .    .  .oP `--.__`.__|__.'           Yo. .      .      ..oP
    `8o.  .  .  .  .o8'            |                `8o.  .   .   . .o8'
      `Y88booood888P'             =.=                 `Y88boooood888P'



");
		Console.WriteLine("8 - Se mantiene el movimiento de manera simultánea y repetitiva(la velocidad dependerá de que tan rápido se aplique la rotación al pedal");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("9 - Para poder rotar la bicicleta a una ángulo vertical deseado se rota el mismo timón en la dirección deseada");
		Console.ReadKey();
		Console.WriteLine("");
		Console.WriteLine("10 - Para detenerla se aplica el freno y se bajan las piernas");
		Console.ReadKey();
		Console.Clear();
		Console.WriteLine(@"
 -------- __@
 ----- _`\<,_
 ---- (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
	-------- __@
	----- _`\<,_
	---- (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
		-------- __@
		----- _`\<,_
		---- (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

"); Thread.Sleep(200);


		Console.Clear();
		Console.WriteLine(@"
			-------- __@
			----- _`\<,_
			---- (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
				-------- __@
				----- _`\<,_
				---- (*)/ (*)
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
"); Thread.Sleep(200);
		Console.WriteLine("");
		Console.WriteLine("Fin");
		Console.ReadKey();

	}

	public static void Algoritmos_4()
    {
		Calculadora();

	}
	public static void Algoritmos_5()
	{
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(@"
                       ____________________
                     //|           |        \
                   //  |           |          \
      ___________//____|___________|__________()\__________________
    /__________________|_=_________|_=___________|_________________{}
    [           ______ |           | .           | ==  ______      { }
  __[__        /##  ##\|           |             |    /##  ##\    _{# }_
 {_____)______|##    ##|___________|_____________|___|##    ##|__(______}
             /  ##__##                              /  ##__##        \
----------------------------------------------------------------------------

");
		Console.WriteLine(" 1 - Como cambiar el aceite de un vehículo de motor");
		Console.WriteLine("");
		Console.ReadKey();

		Console.WriteLine(" 2 - Primero consigue una bicicleta cómoda y que se adapte a tu filosofía y preferentemente con ruedas ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 3 - Eleva el vehículo de ser necesario");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine("Abra el capó");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 4 - Localice la varilla de medición del aceite del motor");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine("retírela ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 5 - luego colocarse en parte imferior del vehiculo ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 6 - Localice el tapón de drenaje del aceite ");
		Console.ReadKey();
		Console.WriteLine(@"
        _________
       |         |
 _o_  _| ___=___ |_  _o_
/`-'( )         ( ) /`-'\
|   |-|  ___*___  |-|   |
|   | | (-+-+-+-) | |   |
|   |--\_KAR120C_/--|   |
");

		Console.WriteLine(" 7 - Coloque debajo del tapón de drenaje un recipiente ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 8 - Afloje el tapón de drenaje usando una llave de tuercas ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 9 - Limpie las roscas");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 10 - Localice el filtro ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 11 - coloque el recipiente de aceite bajo el filtro");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 12 - Afloje el filtro de aceite o la tapa del filtro con una llave de filtro de aceite ");
		Console.ReadKey();
		Console.WriteLine(@"

                      ___..............._
             __.. ' _'.""""""\\""""""""- .`-._
 ______.-'         (_) |      \\           ` \\`-. _
/_       --------------'-------\\---....______\\__`.`  -..___
| T      _.----._           Xxx|x...           |          _.._`--. _
| |    .' ..--.. `.         XXX|XXXXXXXXXxx==  |       .'.---..`.     -._
\_j   /  /  __  \  \        XXX|XXXXXXXXXXX==  |      / /  __  \ \        `-.
 _|  |  |  /  \  |  |       XXX|""'            |     / |  /  \  | |          |
|__\_j  |  \__/  |  L__________|_______________|_____j |  \__/  | L__________J
     `'\ \      / ./__________________________________\ \      / /___________\
        `.`----'.'   dp                                `.`----'.'
");

		Console.WriteLine("13 - Retire el filtro de aceite. Revise que la junta del filtro haya sido retirada junto con el filtro");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 14 - Para facilitar la instalación ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 15 - Bajo el capó ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 16 - Apague el motor");
		Console.ReadKey();
		Console.WriteLine(@"
        __-------__
      / _---------_ \
     / /           \ \
     | |           | |
     |_|___________|_|
 /-\|                 |/-\
| _ |\       0       /| _ |
|(_)| \      !      / |(_)|
|___|__\_____!_____/__|___|
[_________|MEIN1|_________] 
 ||||    ~~~~~~~~     ||||
 `--'                 `--'
");

		Console.WriteLine(" 17 - Con cuidado baje el vehículo hasta el nivel del suelo. ");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 18 - Instale y retire la varilla de medición de aceite");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine("FIN ");
		Console.ReadKey();

	}

	public static void Algoritmos_6()
	{
		Console.WriteLine(@"
               _,,,_
                  //_\\\\
                  ;/ \\\\;
                 (  '7'  )
                  ;  _  ;
                   \ _ /
                .---)_(---.
               /\\  <_>  //\ 
              ;   > / \ <' _;
              |   | | | |   |
         _____|  |\_|_|_/_  |_______
        /    /  /        /  /      /|
       /   \/==/------, /==/      //|
      /    (\( -     /  \\(      //||
     /       / ~~~~ /           // ||
    /       '------'           //  ||
   /__________________________//   ||
   |-------------------------;;    ||
   ||   ||     |  ||  |==||  ||    ||
   ||   ||     |==||==|  ||  ||    ||
   ||   |/    /  / /  /      ||    |/
   ||        (__/ (__/       ||
   ||                        || 
   ||                        ||
   |/                        |/
 

");
		Console.WriteLine(" 1 - Llegar a ser senador en de RD");
		Console.WriteLine("");
		Console.ReadKey();

		Console.WriteLine(" 2 - verificar que seas 100 % del país que deseas ser senador");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 3 - Conoce de las acusaciones formuladas por la Cámara de Diputados contra las y los funcionarios públicos señalados en el artículo 83");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 4 - Opten una identificación civil");
		Console.ReadKey();
		Console.WriteLine(@"

      __...--~~~~~-._   _.-~~~~~--...__
    //               `V'               \\ 
   //                 |                 \\ 
  //__...--~~~~~~-._  |  _.-~~~~~~--...__\\ 
 //__.....----~~~~._\ | /_.~~~~----.....__\\
====================\\|//====================
                    `---`
");

		Console.WriteLine(" 5 - Cumplir más de 25 años de edad");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 6 - Ser nativo de la demarcación territorial");
		Console.ReadKey();
		Console.WriteLine("");

	

		Console.WriteLine(" 7 - Ser elegido o tener más de 5 años consecutivos");
		Console.ReadKey();
		Console.WriteLine("");

	
		Console.WriteLine("FIN ");
		Console.ReadKey();

	}

	public static void Algoritmos_7()
	{
		Console.Clear();
		Console.WriteLine(@"
(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)
 

");
		Console.WriteLine("1 - Como desarrollar un algoritmo");
		Console.WriteLine("");
		Console.ReadKey();

		Console.WriteLine(" 2 - Se busca el tema el cual se realizara el algoritmo");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 3 - Se obtiene buen conocimiento del tema");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 4 - Se investiga los pasos necesarios para realizar dicho algoritmo");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 5 -  Se realiza el algoritmo");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 6 - Se enlista todas la acusación");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 7 - Colocan las acciones de manera cronológica");
		Console.ReadKey();
		Console.WriteLine("");


		Console.WriteLine(" 8 - Se colocan las acciones de manera sucesiva");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 9 - Se asegura que el algoritmo tenga final");
		Console.ReadKey();
		Console.WriteLine("");

		Console.WriteLine(" 10 - se finalisa");
		Console.ReadKey();
		Console.WriteLine("");



		Console.WriteLine(" 11 - Corroboran que todos los pasos sean correctos");
		Console.ReadKey();
		Console.WriteLine("");

		Console.Clear();
		Console.WriteLine(@"
,         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |j  |  |
|  | g |  |
 \ |  s| /
  \|===|/
   '---'
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
   ,   ,
  /////|
 ///// |
|~~~|  |
|===|  |
|j  |  |
| g |  |
|  s| /
|===|/
'---'
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
,         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |j  |  |
|  | g |  |
 \ |  s| /
  \|===|/
   '---'

"); Thread.Sleep(500);


		Console.Clear();
		Console.WriteLine(@"
   ,   ,
  /////|
 ///// |
|~~~|  |
|===|  |
|j  |  |
| g |  |
|  s| /
|===|/
'---'
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
,         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |j  |  |
|  | g |  |
 \ |  s| /
  \|===|/
   '---'
"); Thread.Sleep(500);


		Console.Clear();
		Console.WriteLine(@"
   ,   ,
  /////|
 ///// |
|~~~|  |
|===|  |
|j  |  |
| g |  |
|  s| /
|===|/
'---'
"); Thread.Sleep(500);

		Console.Clear();
		Console.WriteLine(@"
,         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |j  |  |
|  | g |  |
 \ |  s| /
  \|===|/
   '---'
"); Thread.Sleep(500);


		Console.WriteLine("FIN ");
		Console.ReadKey();

	}

	public static void Algoritmos_8()
	{
		Console.WriteLine(@"

 

");

		Console.Clear();
		Thread.Sleep(200);
		Console.WriteLine(@"
 _________________________   
|   |     |     |    | |  \  
|___|_____|_____|____|_|___\ 
|                    | |    \
`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
	 _________________________   
	|   |     |     |    | |  \  
	|___|_____|_____|____|_|___\ 
	|                    | |    \
	`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
		 _________________________   
		|   |     |     |    | |  \  
		|___|_____|_____|____|_|___\ 
		|                    | |    \
		`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
			 _________________________   
			|   |     |     |    | |  \  
			|___|_____|_____|____|_|___\ 
			|                    | |    \
			`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````

"); Thread.Sleep(200);


		Console.Clear();
		Console.WriteLine(@"
				 _________________________   
				|   |     |     |    | |  \  
				|___|_____|_____|____|_|___\ 
				|                    | |    \
				`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
"); Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
					 _________________________   
					|   |     |     |    | |  \  
					|___|_____|_____|____|_|___\ 
					|                    | |    \
					`--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````
");
		Thread.Sleep(200);

		Console.Clear();
		Console.WriteLine(@"
::::::::::: ::::::::::: :::            :::     
    :+:         :+:     :+:          :+: :+:   
    +:+         +:+     +:+         +:+   +:+  
    +#+         +#+     +#+        +#++:++#++: 
    +#+         +#+     +#+        +#+     +#+ 
    #+#         #+#     #+#        #+#     #+# 
###########     ###     ########## ###     ### 
"); Thread.Sleep(500);


		Console.WriteLine(" 1 - Como llegar al itla desde tu casa");
		Console.WriteLine("");
		Console.ReadKey();

		Console.WriteLine(" 2 - Salgo de su casa y diríjase a la parada de autobús más cercana");
		Console.ReadKey();
		Console.WriteLine("");

		
		string respo;

		Console.Write("sabe usted donde es(escriba la respuesta) = ");
		respo = Console.ReadLine()??"no";

        if (respo == "si" || respo == "1" || respo == " si" || respo == "1" || respo == "si " || respo == "yes" || respo == " si " || respo == "1") {
			Console.WriteLine(" 3 - diríjase al trasporte público");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 4 - Luego espere a que llegue el trasporte público");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 5 - con el mismo se dirije a la parada de transporte de la institucion mas sercano");
			Console.ReadKey();
			Console.WriteLine("");

			Console.Write(" 6 - Usted posee el ticket de ese día : ");
			string respo2 = Console.ReadLine() ?? "no";
			if (respo == "si" || respo == "1" || respo == " si" || respo == "1" || respo == "si " || respo == "yes" || respo == " si " || respo == "1")
			{
				Console.WriteLine(" 7 - Espere a que llegue el vehículo de la institución");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 8 - se sube al vehiculo de la institucion");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 9 - Espere a que llegue al itla");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 10 - Me bajo del vehículo ya en la institución");
				Console.ReadKey();
				Console.WriteLine("");
			}
			else {
				Console.WriteLine(" 8 - subace a un vehiculo de trasporte publico ");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 8.1 - detenguase en la duarte ");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 8.2 - tome otro trasporte que balle a boca chica ");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 9 - Espere a que llegue al itla");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 10 - Me bajo del vehículo ya en la institución");
				Console.ReadKey();
				Console.WriteLine("");

			}


		}
		else {
			Console.WriteLine(" 3 - investigue  (y de paso salgua mas amenudo)");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 4 - Luego espere a que llegue el trasporte público");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 5 - con el mismo se dirije a la parada de transporte de la institucion mas sercano");
			Console.ReadKey();
			Console.WriteLine("");

			Console.Write(" 6 - Usted posee el ticket de ese día : ");
			string respo2 = Console.ReadLine() ?? "no";
			if (respo2 == "si" || respo == "1")
			{
				Console.WriteLine(" 7 - Espere a que llegue el vehículo de la institución");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 8 - se sube al vehiculo de la institucion");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 9 - Espere a que llegue al itla");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 10 - Me bajo del vehículo ya en la institución");
				Console.ReadKey();
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine(" 3 - investigue  (y de paso salgua mas amenudo)");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 4 - Luego espere a que llegue el trasporte público");
				Console.ReadKey();
				Console.WriteLine("");

				Console.WriteLine(" 5 - con el mismo se dirije a la parada de transporte de la institucion mas sercano");
				Console.ReadKey();
				Console.WriteLine("");

			}



		}



		Console.WriteLine("FIN ");
		Console.ReadKey();

	}

	public static void Algoritmos_9()
    {
		{
			Console.Clear();
			Console.WriteLine(@"
       .                                                   . 
      .;;,                                                ,;;. 
      ;;,;;,                                            ,;;,;; 
      ;;,;;; .~~~%%%~~~%%%~~~%%%~~~%%%~~~%%%~~~%%%~~~%. ;;;,;; 
      `;;,'.~~%%%~~~%%%~~~%%%~~~%%%~~~%%%~~~%%%~~~%%%~~~.`,;;' 
        `.;;'''';;;;;;;;'''';;;;;;;;;'''';;;;;;;;;'';;;;;;.' 
       .;;;; ;;;;;'  `;; ;;;;;   `;;; ;;;;;;;'';;;  ;;;;;;;; 
       ;;;;;,  `;; ;;;;;  `;;; ;;; ;;,  `;;;;  ;;;..;;;;;;;; 
       ;;;;;;;; ;;  `;;; ;;;;; ;;; ;;;;; ;;;;..;;;;;;;;;;;;; 
       ;;;;;'  ,;; ;;;;;,  `;; ;;; ;;'  ,;;;;;;;;;  ;;;;;;;; 
       `;;;;;;;;;;,  `;;;;;;;;   ,;;;;;;;;;;;  ;;;;;;;;;;;;' 
        ;;;;;;;;;;;;;;;;''''';'''';;'''';;;;;;;;;;;;;;;;;;; 
        ;;;;;;;;;;;;;;; )(()) ())) )())() ;;;;;;;;;;;;;;;;' 
       .;;;;;;;;;;;;; )()()(( (())) (())( ;;;;;;;;;;;;;;;; 
       ;;;;;;;;;;;;;;; (a@a)( )()(() a@a ;;;;;;;;;;;;;;;;; 
       ;;;;;;;;;;;;;; @@@@@ ;; a@a ; @@@@@ ;;;;;;;;;;;;;;;. 
      .;;;;;;;;;;;;; @@@@@ ;; @@@@@ ; @@@@@ ;;;;;;;;;;;;;;; 
      ;;;;;;;;;;;;;; @@@ ;;;; @@@@@ ;;; @@@ ;;;;;;;;;;;;;;; 
      ;;;;;;;;;;;;;; @ ;;;;;;; @@@ ;;;;;; @ ;;;;;;;;;;;;;;; 
   .;;`;;;;;;;;;;;;;;,;;;;;;;;; @ ;;;;;;;;,;;;;;;;;;;;;;;;';;. 
 .;;;;,`;%%%~~~%%%~~~%%%~~~%%%~~,%%%~~~%%%~~~%%%~~~%%%~~~';,;;; 
;;;;,;;;`,  %%%   %%%   %%%   %%%   %%%   %%%   %%%   %%';;;;,;; 
;;;;;;;'  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~   `;;;;;; 
 `;;;'                                                        '';

");
			Console.WriteLine(" 1 - Como preparar una yaroa de papas con pollo.");
			Console.WriteLine("");
			Console.ReadKey();

			Console.WriteLine(" 2 - Se busca los ingredientes necesarios");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 3 - Se limpia las papas");
			Console.ReadKey();
			Console.WriteLine(" 4 - Se cortan en rodajas finas y de la forma deseada");
			Console.ReadKey();

			Console.WriteLine(" 5 - se enarina");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 6 - se ensiende el fuego y se coloca un embase admitible con aceite");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 7 - se coloca el aceite");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 8 - luego colocas las papas en el mismo");
			Console.ReadKey();
			Console.WriteLine("");


			Console.WriteLine(" 9 - se corta el pollo");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 10 - despues se sasona el pollo");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 11 - luego se enarina");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 12 - se pone a freir en una olla con aceite a freir");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 13 - luego se cortan en pedasos pequeños");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 14 - Se sirven al junto con las papas");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 15 - Se gratina un poco de queso de preferencia");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 16 - Lo colocas arriba de la preparación");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine("FIN ");
			Console.ReadKey();

		}
	}

	public static void Algoritmos_10()
	{
		{
			Console.Clear();
			Console.WriteLine(@"
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |  C:\> stiven de la rosa                 |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/
                ___________________________________________
             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
 _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
:-------------------------------------------------------------------------:
`---._.-------------------------------------------------------------._.---'
");
			Console.WriteLine(" 1 - Comprar una laptop en internet.");
			Console.WriteLine("");
			Console.ReadKey();

			Console.WriteLine(" 2 - Enciende su dispositivo ");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 3 - Entra al navegador de preferencia ");
			Console.ReadKey();


			Console.WriteLine(" 4 - Investigas antes los componentes deseados");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 5 - Entra a la página de compras preferidas");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 6 - Busca la portátil teniendo en cuenta los requisitos deseados");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 7 - Verifica si alguna ítem del catálogo cumpla con tus requerimientos ");
			Console.ReadKey();
			Console.WriteLine("");


			Console.WriteLine(" 8 - Ves las reseñas si son positivas");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 9 - Lo agregas la caja de compras");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 10 - Pagua de la forma deseada");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 11 - Verifica que cumpla y sea tal cual como la solicitaste");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine(" 12 - De lo contrario demanda un rembolso");
			Console.ReadKey();
			Console.WriteLine("");

			Console.WriteLine("FIN ");
			Console.ReadKey();

		}
	}



	public static void Calculadora()
	{
		Console.Clear();
		Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|
");

		int entrada_1, entrada_2, result = 0;
		Console.Write("Ingrese un numero : ");
		int.TryParse(Console.ReadLine(), out entrada_1);
		Console.Write("Ingrese otro numero : ");
		int.TryParse(Console.ReadLine(), out entrada_2);


		result = entrada_1 + entrada_2;


		Console.WriteLine(@"

 _____________________
|  _________________  |
| |                 | |
| | {1} + {2} = {0}   
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|
", result , entrada_1 , entrada_2);


		Console.ReadKey();

	}











};


