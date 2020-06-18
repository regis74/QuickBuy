import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent implements OnInit {
  public usuario = new Usuario();
  public returnUrl: string;

  //passando como parametro no construtor, esta injetando a dependencia
  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }


  entrar() {
    //METODO QUE TEM RETORNO O OBSERVABLE
    //no "subscribe" que de fato vai iniciar a chama ao serviço web no ASPNet.Core
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        data => {
        },
        err => {
        });

    //if (this.usuario.email == "email@email.com" && this.usuario.senha == "senha") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
    //}
  }

}
