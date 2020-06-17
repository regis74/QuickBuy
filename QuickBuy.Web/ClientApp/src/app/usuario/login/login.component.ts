import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent implements OnInit {
  public usuario = new Usuario();
  public returnUrl: string;

  //passando como parametro no construtor, esta injetando a dependencia
  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
    
    
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }


  entrar() {
    if (this.usuario.email == "email@email.com" && this.usuario.senha == "senha") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
  }

}
