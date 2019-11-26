import { Pessoa } from './../../model/pessoa';
import { ApiService } from './../_services/api.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-pessoas-lista',
  templateUrl: './pessoas-lista.component.html',
  styleUrls: ['./pessoas-lista.component.css']
})
export class PessoasListaComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
