public class Retangulo {

    public double altura;
    public double largura;

    public Retangulo(double altura, double largura) {

        this.altura = altura;
        this.largura = largura;

    }

    public Retangulo(double altura) {

        this.altura = altura;
        this.largura = altura;

    }

    public Retangulo() {

        this.altura = 0;
        this.largura = 0;

    }

    public double CalcularArea() {

        return altura*largura;

    }

    public double CalcularPerimetro() {

        return altura*2+largura*2;

    }

    public void Redimensionar() {


    }

    public void Redimensionar(double fator) {
        
        altura*=fator;
        largura*=fator;

    }

    public void Redimensionar(double novaAltura, double novaLargura) {
        
        altura = novaAltura;
        largura = novaLargura;

    }

}