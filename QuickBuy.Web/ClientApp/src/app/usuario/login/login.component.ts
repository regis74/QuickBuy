import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario = new Usuario();

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    //if (this.usuario.email == "email@email.com" && this.usuario.senha == "senha") {
    //}
  }

}
