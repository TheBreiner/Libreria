//clase principal
public class Libro 
// atributos
{ private int ISBN,páginas;
private string Titulo="",autor="";
   public void gettitulo(){
        Console.WriteLine(this.Titulo);
    }
public void settitulo(string nombrel){
        this.Titulo=nombrel;
}
    public void getautor(){
        Console.WriteLine(this.autor);
    }
public void setautor(string nombrea){
        this.autor=nombrea;
}
    public void getIBSN(){
        Console.WriteLine(this.ISBN);
    }
public void setIBSN(int ncode){
        this.ISBN=ncode;
}
    public int getnpages(){
        return this.páginas;
    }
public void setnpages(int npagi){
        this.páginas=npagi;
}     
   
  public void tostring(){ Console.WriteLine("El libro "+this.Titulo+" con ISBN "+this.ISBN+" creado por el autor "+this.autor+" tiene "+this.páginas+" páginas.");
  }
}