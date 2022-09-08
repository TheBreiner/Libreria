//clase principal
public class Bibloteca {
    // metodo principal
        public static void Main(string[] args) {
       //define una instancia de libro como la divina y konosuba como nueva
        Libro Divina_comedia=new Libro ();
		Libro kono_subarashii_sekai_ni_shukufuku_wo=new Libro ();
       //configurar titulo
        Divina_comedia.settitulo("divina comedia" );
        //configurar ibsn
		Divina_comedia.setIBSN(97884);
        //configurar paginas
		Divina_comedia.setnpages(700);
        // configurar el autor
		Divina_comedia.setautor("Dante Alighierit");
        //lee los valores,convierte y los muestra en pantalla
		Divina_comedia.tostring();

         //configurar titulo
        kono_subarashii_sekai_ni_shukufuku_wo.settitulo("kono subarashii sekai ni shukufuku wo");
          //configurar ibsn
		kono_subarashii_sekai_ni_shukufuku_wo.setIBSN(978841);
        //configurar paginas
		kono_subarashii_sekai_ni_shukufuku_wo.setnpages(500);
        // configurar el autor
		kono_subarashii_sekai_ni_shukufuku_wo.setautor("Natsume Akatsuki");
        //lee los valores,convierte y los muestra en pantalla
		kono_subarashii_sekai_ni_shukufuku_wo.tostring();
     
     //condiconal si  mira quie tiene mas paginas
        if (Divina_comedia.getnpages() > kono_subarashii_sekai_ni_shukufuku_wo.getnpages())
         // muestra que la divina comedia tiene mas paginas 
        {   Console.WriteLine (" Divina comedia Tiene Mas Paginas");}
		else {
                 // muestra en pantalla que konosuba tiene mas paginas si es verdad
                	Console.WriteLine (" kono subarashii sekai ni shukufuku wo Tiene Mas Paginas");
            	}


             
        }
    }
