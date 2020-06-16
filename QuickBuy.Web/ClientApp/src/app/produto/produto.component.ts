import { Component } from "@angular/core";

//decorator @Component que vai configurar o ProdutoComponent
//nome da tag html que o ProdutoComponent vai ser renderizado
@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})

//depois adicionar import no app.module.ts
export class ProdutoComponent { 
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string{
    return "Samsung2";
  }
   
}
