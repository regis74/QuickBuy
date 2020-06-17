import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from '@angular/router';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario = new Usuario();

  //passando como parametro no construtor, esta injetando a dependencia
  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "email@email.com" && this.usuario.senha == "senha") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/']);
    }
  }

}
