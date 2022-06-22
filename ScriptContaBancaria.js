class ContaBancaria {
    construtor(agencia, numero, tipo) {
        this.agencia = agencia;
        this.numero = numero;
        this.tipo = tipo;
        this._saldo = 0;
    }

    get saldo() {
        return this._saldo;
    }

    set saldo(valor) {
        this._saldo = valor;
    }

    sacar(valor) {
       if(valor > this._saldo) {
           return 'Operação Negada!'
       }
       this._saldo = this._saldo - valor;

       return this._saldo;
    }

    depositar(valor) {
        this._saldo = this._saldo + valor; 
        return this._saldo;
    }
}

class contaCorrente extends ContaBancaria {
    constructor(agencia, numero, cartaoCredito) {
    super(agencia, numero);
    this.tipo = 'contaCorrente';
    this.cartaoCredito = cartaoCredito;
   }

   get cartaoCredito() {
       return this._cartaoCredito;
   }

   set cartaoCredito(valor) {
     this._cartaoCredito = valor;
   }
}

class contaPoupança extends ContaBancaria  {
    constructor(agencia, numero) {
    super(agencia, numero);
    this.tipo = 'Poupança';
     }
}

class contaUniversitaria extends ContaBancaria {
    constructor(agencia, numero) {
    super(agencia, numero);
    this.tipo = 'Universitaria';
     }

     sacar(valor) {
         if(valor > 500) {
             return 'Operação negada!'
         }

         this._saldo = this._saldo -valor;
     }
}

