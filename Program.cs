using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int tamano = 0;
            int ActividadPerro = 0;
            double peso = 0.0;
            string nomb = "";
            int opcion;
            int meses = 0;
            do
            {

                Console.WriteLine("Bienvenidos a programa de cuanto debe comer tu perro.\n\n");
                Console.WriteLine("Indicame el nombre de tu canino.");
                nomb = Console.ReadLine();

                Console.WriteLine("Escriba 1 si {0} es un cachorro, o escriba 2 si es un perro adulto.", nomb);
                string info = Console.ReadLine();
                tamano = Convert.ToInt32(info);

                if (tamano == 1)
                {
                    Console.WriteLine("{0} es un CACHORRO", nomb);
                    Console.WriteLine("¿Cuanto pesa tu cachorrito?");
                    dato = Console.ReadLine();
                    peso = Convert.ToDouble(dato);
                    //MINIATURA
                    if (peso <= 2)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño MINIATURA", nomb);
                    }
                    //PEQUEÑO
                    if (peso <= 5 && peso > 2)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño MINIATURA", nomb);
                    }
                    if (peso <= 10 && peso > 5)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    //MEDIANO
                    if (peso <= 17 && peso > 10)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño GRANDE", nomb);
                    }
                    if (peso <= 25 && peso > 17)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    if(peso <= 32 && peso > 25)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    if (peso <= 40 && peso > 32)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    //GRANDE
                    if (peso <= 50 && peso > 40)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño GRANDE", nomb);
                    }
                    if (peso <= 60 && peso > 50)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    if (peso <= 70 && peso > 60)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    if (peso <= 90 && peso > 70)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }

                    //MESES DEL PERRO

                    Console.WriteLine("¿Como considera la actividad de su mascota?");
                    Console.WriteLine("1 - Edad de 2 meses");
                    Console.WriteLine("2 - Edad de 3 meses");
                    Console.WriteLine("3 - Edad de 4 meses");
                    Console.WriteLine("4 - Edad de 5 meses");
                    Console.WriteLine("5 - Edad de 6-12 meses");
                    dato = Console.ReadLine();
                    meses = Convert.ToInt32(dato);


                    //CACHORRO MINIATURA
                    if (peso <= 2)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 50 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 60 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 60 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 60 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 55 gramos de alimento.");
                                break;
                        }
                    }
                    //CACHORRO PEQUEÑO
                    if (peso <= 5 && peso > 2)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 95 gramos de alimento de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 110 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 115 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 115 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 110 gramos de alimento.");
                                break;
                        }
                    }
                    if (peso <= 10 && peso > 5)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 155 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 185 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 195 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 190 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 185 gramos de alimento.");
                                break;
                        }
                    }

                    //CACHORRO MEDIANO

                    if (peso <= 17 && peso > 10)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 215 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 265 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 285 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 285 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 280 gramos de alimento.");
                                break;
                        }
                    }
                    if (peso <= 25 && peso > 17)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 270 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 350 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 375 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 375 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 370 gramos de alimento.");
                                break;
                        }
                    }
                    if (peso <= 32 && peso > 25)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 300 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 400 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 445 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 450 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 450 gramos de alimento.");
                                break;
                        }
                    }
                    if (peso <= 40 && peso > 32)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 355 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 475 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 525 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 530 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 530 gramos de alimento.");
                                break;
                        }
                    }

                    //CACHORRO GRANDE

                    if (peso <= 50 && peso > 40)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 405 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 545 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 610 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 625 gramos de alimento.");
                                break;
                            case 5:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                        }
                    }

                    if (peso <= 60 && peso > 50)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 450 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 605 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 685 gramos de alimento.");
                                break;
                            case 4:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                            case 5:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                        }
                    }
                    if (peso <= 70 && peso > 60)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 485 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 670 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("A partir de esta edad y peso y peso su cachorro ya es considerado adulto.");
                                break;
                            case 4:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                            case 5:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                        }
                    }
                    if (peso <= 90 && peso > 70)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 580 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                            case 3:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                            case 4:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                            case 5:
                                Console.WriteLine("A partir de esta edad y peso su cachorro ya es considerado adulto.");
                                break;
                        }
                    }


                }






                //ADULTO

                if (tamano == 2)
                {
                    Console.WriteLine("{0} Es un perro ADULTO.", nomb);
                    Console.WriteLine("¿Cuánto pesa {0}?", nomb);
                    dato = Console.ReadLine();
                    peso = Convert.ToDouble(dato);

                    if (peso <= 5 && peso >= 2)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño MINIATURA", nomb);
                    }
                    if (peso <= 10 && peso > 5)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño PEQUEÑO", nomb);
                    }
                    if (peso <= 15 && peso > 10)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño MEDIANO", nomb);
                    }
                    if (peso <= 90 && peso > 15)
                    {
                        Console.WriteLine("Su mascota {0} es tamaño GRANDE", nomb);
                    }


                    //Actividad del perro

                    Console.WriteLine("¿Como considera la actividad de su mascota?");
                    Console.WriteLine("1 - Actividad Alta");
                    Console.WriteLine("2 - Actividad Normal");
                    Console.WriteLine("3 - Actividad Baja");
                    dato = Console.ReadLine();
                    ActividadPerro = Convert.ToInt32(dato);


                    //Tamaño Miniatura
                    if (peso <= 5 && peso >= 2)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 45 -85 gramos.");
                                break;
                        }
                    }
                    //Tamaño Pequeño
                    if (peso <= 10 && peso > 5)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 100 - 170 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 85 - 145 gramos de alimento.");
                                break;
                        }
                    }
                    //Tamaño Mediano
                    if (peso <= 15 && peso > 10)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 170 - 225 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 145 - 195 gramos de alimento.");
                                break;
                        }
                    }
                    //Tamaño Grande 1
                    if (peso <= 25 && peso > 15)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 255 - 380 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 225 - 330 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 195 - 285 gramos de alimento.");
                                break;
                        }
                    }
                    //Tamaño Grande 2
                    if (peso <= 40 && peso > 25)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 380- 535 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 330 - 475 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 285 - 410 gramos de alimento.");
                                break;
                        }
                    }
                    //Tamaño Grande 3
                    if (peso <= 55 && peso > 40)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 535 - 680 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 475 - 600 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 410 - 520 gramos de alimento.");
                                break;
                        }
                    }

                    //Tamaño Grande 4
                    if (peso <= 70 && peso >55 )
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 680 - 820 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 600 - 720 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 520 - 620 gramos de alimento.");
                                break;
                        }
                    }
                    //Tamaño Grande 5
                    if (peso <= 90 && peso >70 )
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 820 - 985 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 720 - 870 gramos de alimento.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 620 - 750 gramos de alimento.");
                                break;
                        }
                    }
                }










                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                Console.Clear();


            } while (opcion != 4);





        }
    }
}
