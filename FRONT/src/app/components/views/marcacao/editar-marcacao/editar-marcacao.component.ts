import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Marcacao } from 'src/app/models/marcacao';
import { MarcacaoService } from 'src/app/services/marcacao.service';

@Component({
  selector: 'app-editar-marcacao',
  templateUrl: './editar-marcacao.component.html',
  styleUrls: ['./editar-marcacao.component.css']
})
export class EditarMarcacaoComponent implements OnInit {

    constructor(private router: Router, private serivce: MarcacaoService) { }

    id!: number;
    funcionarioId!: Number
    dataMarcacao!: string;
    horaEntrada!: string;
    horaSaidaAlmoco!: string;
    horaVoltaAlmoco!: string;
    saida!: string;

    ngOnInit(): void {
    }

    update(): void{

      let marcacao: Marcacao ={
          id: this.id,
          funcionarioId: this.funcionarioId,
          dataMarcacao: this.dataMarcacao,
          horaEntrada: this.horaEntrada,
          horaSaidaAlmoco: this.horaSaidaAlmoco,
          horaVoltaAlmoco: this.horaVoltaAlmoco,
          saida: this.saida,
      }
      this.serivce.update(marcacao).subscribe(marcacao =>{
          console.log(marcacao)
          this.router.navigate(["marcacao/listar"]);
      });


    }

}
