// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public enum TipoExtraccion {
    CajeroHumano = 1,
    CajeroAutomatico = 2
}
public enum TipoDeCuenta {
    CorrientePesos = 1,
    CorrienteDolares = 2,
    AhorroPesos = 3
    
}
public class Cuenta {
    int monto; 
    TipoDeCuenta tipo;
    public Cuenta(TipoDeCuenta tipo, int monto){
        this.tipo = tipo;
        this.monto = monto;
    }

    public void Insercion(int monto) {
        this.monto += monto;
    }

    public int Extraccion(int monto, TipoExtraccion tipo) {
        if (this.tipo == TipoDeCuenta.AhorroPesos ) {
            if(monto > this.monto) {
                System.Console.WriteLine("No hay fondo suficiente");
                return 0;
            } else {
                if (tipo == TipoExtraccion.CajeroHumano)
                {
                    this.monto = this.monto - monto;
                    return monto;
                } else {
                    if(monto <= 10000) {
                        this.monto = this.monto - monto;
                        return monto;
                    } else {
                        monto = 10000;
                        this.monto = this.monto - monto;
                        System.Console.WriteLine("Maximo de extraccion: $10.000");
                        return monto;
                    }
                } 
            }
        } else if(this.tipo == TipoDeCuenta.CorrienteDolares) {
            if(monto > this.monto) {
                System.Console.WriteLine("No hay fondo suficiente");
                return 0;
            } else {
                if (tipo == TipoExtraccion.CajeroHumano)
                {
                    this.monto = this.monto - monto;
                    return monto;
                } else {
                    if(monto <= 200) {
                        this.monto = this.monto - monto;
                        return monto;
                    } else {
                        monto = 200;
                        this.monto = this.monto - monto;
                        System.Console.WriteLine("Maximo de extraccion: USD$200");
                        return monto;
                    }
                } 
            }
        }
        

        }
    }




