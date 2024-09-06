using System;

public class SobreMi
{
	public static void Sobre_mi()
	{

        Console.Clear();

        ConsoleColor original = Console.ForegroundColor;


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"

                                        ..                                                
                                 .i77IjU1XI2227rir:                                       
                            .UZPPKq5IuJUSsJuj1PXPqEEEdPUr.                                
                        .XPgDdUYujirY1v7rvvJJL7iiL77YqXPPbSJi.                            
                     .SbMZX1uvvrY17rrrj17rrvU7iiiivv1uu12sSqdKXv.                         
                   i2gZbXSXXvii7r7r7iirLvvLLi:71Lsj1uUs2uUuuU55Pq1.                       
                 iPZdqq5XUSq57ri7r7r7r:iv777vv2IuUUv11UjJsjvsjuJ1IP5r                     
                IEPKISXq22SKjUuYJIu1IUrjUuvvv1L7sUYv7vsIvLYjYuLs7JjIqX:                   
              YZPSX5X1XSUIXsJJJuJ1X1IJvL5UYvsJv7UsLL7vssLriLjYvvYvJvJuPJ                  
            .qb5uI15I1ISS515I1JS2vv11Xjrj2rU1KuuY7Y17Jvi71svYLLusYrr7JsI5i                
           7Dq5U1UKII122Is12UU25IL::UIJ7s1LvjJYiriirvuvi:ru77vUsurri7YsvuK5               
          iZ5IU11SuU21JX2LvL7YYJ7:.iri::.:::......   ...   .  .:.:iLYv7Lv155              
         1g21uUJUI5u52Sj7:::............. ..... . .               ....vL7L1Xq.            
        LRK5uuuuuS2JvLr:::.:::.....................        .   . .     vrvvJuq.           
       rDSXUJ11js7rii::::::::.:............ .......             . . .  :i7v7sUP           
      .RSSU1uUYLii:iii:ri:::::.:.......... . .....   . .         . .  .::iiL7YIS          
      Z5I25jjri:iirrriiiiii::::::............ .     . ...   . . . .   ...:irrLY1L         
     KPIUU12Y7irirrrrrriii::::::...... . . . . .   .......   .   . .   .:ii:i7rL5:        
    igX22u2UJ7rirrririrriii:::::::........... ............. . .   . .  .:ii:rrrrUL        
    KEIIIIuuuJiiiririrrriii::::::::........... . . . ....... . ... .   ..:::rrrrvI.       
    gXI12uIj2sriririiiiiiii::::................ . .......   . .       .   ..iiiivIi       
   .gXU2221Yv7rrrrrririiii::.................. . ...                   .     rrirUv       
   :gIIU1151Yrriririiiii:.::........... . .     . .                           rrivj       
   iR5UILuUIvrirri:i::::.:.:....   .                             ..:::.        :iLJ       
   .MSUuIJUv::rii::..........             .          ....i2IPXKXbZbXPS2jsi.     77u       
   .gXI2jILi:iii:..:::ii::......:.               ..:v2PgBBBBQBBBQBBQBBQQBBQ57r..iJj       
    PPS227i::....iIKXKbqbPdbEgRDMPXu7:.       ..iYqRBBBZK1JLv77iiii:rrLY2KRBBBBBBJJ       
    vMUjv..::7YKgBBBQQQBBBQQBBQQMQQBBBBDPPSPXb5SQBBXr.   .......          .7BBBQX7u       
     RK5PPMBBQBMb1sLvr7rr7rrv7rir777L2QBBBBBBBK5BK    .::irr7iiii..       . 1Bdr .2       
     EXgQBBBEY7v77ii::.....:r777vJYY7r:KBBBBq5JDB   .irvL22KPDdgEZdP217:..  .Br 7rK       
     sUidRBR.rYL7rri:::ivvII55q5Su1JjsLrQM2r7r7QB  .::rsX2J7XQQdPqguSgQDX7: .B:  K7       
      j72XgB:777rrr7YKbZMBQPEU71Iq2IXKuvBXrv7vLdBr :ii7521jYudPPKPUU25j2Uvi.:B.  s .::.   
      UPgrvB7rvvYudMQP2dQQQqZIUISSXXdKvvBUv:.  YBQ  ::777vsLr::...:i:.  ..:riB   .:.. ..  
      .Bji:BJr7YUbggbPKPbbX51211JIqv.  IBU...   :BE  ..:iYJ7.. ....i...... .rB        .r. 
       Lji:gb:7v1JYvvLJsJYJs1Juj1S7   .BZ::..    :BI    ..i::...i.ii:::.... qZ        .:. 
  rrLv. v7:uB:r7r7rrrv7LYJJJYjjjLs    gB::::..    .BP           ..::::::.. .M:   .    .:  
 :Pjr71srri.BU:rrrriiirrrrv7777iiii  UBY:ii:...     Ev            ...:..::7J.         :.  
 iPKUvr7rr::jQ.iiiirrriririiii::::iiLQKvrri...       2S7ir::.::i:ir77rr7i:.           ..  
 .SUXurr7ri::irirrrrririri::i:iirv5dgI7ii::..         ...:ii::iii:::.             ...     
  s2SY:7rr:i:::iirr7rrr7rrrrr77s2ZXr..::.::..               .                      :.     
  sUI:rvYi:ii::...::::::::::iii7Iv      .:::.               . .                    ii     
  :qY:v22i:iii::::::::::::::.:.r1:   ..:7vi. .     :ir7uL.     .                      .   
   Is:jIPri::::::::::::........iuv.  i115ISUr .. .:....:i..     . .                  :    
   .1ivIPY::::::::::::..     .:iijYr:irriiv22v:..:......         ...                 :    
    vriY2Li:i:i::::::..     .:iiiir7vvvrri:.......  .             ...           .         
     2Lr.:rriiii::::...... .:::i:::i:iii::..   ..... .             ...           . .      
     .XIii7rrr7ii::::......:::i:i:i:i:i::::...::i::..               ...                   
      .1ir7rr7rrri::::...::i:i::ii:i:::::::rirriiriiii:i:.         .  ..           .      
       .ri7rrr7rrii:::::::i:iiiii::::::issujjJUr7777v7v7YvLr.      ..           .         
        rrrL77r7r7ri:i::ii:irrii::.:7jjuYYLvr7r:.::i:::::ir7r7iiUY.....                   
        .7SPUv7777rii:::iii:777rri7L1JjYJss7r:::::irrr7iirrrrvqDPsi....                   
             LY777iiii:iiriii7ugDbPPKKI1jUJUj7irYJ7riiii::.:irL: .....                    
              Uv7rrii:i:iiriri7uKEgKu77rr:i.....:::.:.::i::.::   ....                     
              .27rrrir:i:::iirrr:ir777rr:::. ...:iii::i:::::.    .                        
               :Jr7rrir:i:iiiirrriii77Lvvri:.. .::::::i::..       . .                     
                1L7rirrrii:iii:rr7r7rrrYJUJJr:.::i:::ii:..                                
                IYY77rriiii:iiiiriri7rriiirrririri::::.         .           :             
                UuYsvvrrrrii:iiirrirrriii::::i::i:::....       . .        .::             
                SjsLJYLv7rririiirrrrrriiiii:i:i::.:::..                 ..:::             
                5uvssssjLL7vrririrrviriii:::::::.. ...   .           ....:.::             
                51jYujus1uuLvr7r7rrY7ii:::i::....                   ..:::::::             
                X2Juu1JUJuJ1uY77r7ir7rrrrr:::... .                .:.:::::.::             
                KU1suJUUUJ1JU11sv7rr7777Lri::.... .              .i:iii::.:.7.            
                7bu1j11UUI2UsujI1uvv7777rrii::.. ...           .:i:ii:::...:.             
                 PquUjUJI1IISUUuIU51sv7rrrrrr:i:....... .....::i::i::::.:..:              
                  PPuuJu1UuI5KI21U1I22Js7v7Lv77rii:i:i:iirrrii:::i::.:.:..:.              
                   1dUJLuJ1u2IXSS1U12U522jJYJsJLYvv77r7rrrrii:::i::......i:               
                    :PqjvYYssuuIIS552IU212jusJvYLL77rrrrii:i:i:i::.....:i.                
                      vdPsv7LvYYuuSISI211j1ssLLvL77rriiii:i:i::.... ..i:                  
                        iKP2vv7v7LY11I12uUjYvL77rriiii:iiiii:....  .ii                    
                          :rKIu77rrrvvuj1suJsLY7iiiiiiiii:..... ..i..                     
                             :Y5I17rirr77YvLvL77riiiii::.... ..rr:                        
                                :iYSIJvr7rriiii::::::.... ..rvv.                          
                                    .rJ2sJvr::::......  .i:::                             
                                          ............irj          

");
        Console.WriteLine("aserca de mi");
        Console.WriteLine(@"
    NOMBRE : Stiven
    APELLIDO : De La Rosa Brito
    TELEFONO : 829-653-6510
    UNIVERSIDAD : ITLA
    CARRERA : desarrollador de software
    MATRICULA : 2022-0457



");

        Console.ReadKey();
    }
}
