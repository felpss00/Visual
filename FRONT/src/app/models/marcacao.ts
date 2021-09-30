export interface Marcacao
{
    id?: number,
    funcionarioId: Number
    dataMarcacao: string;
    funcionario?: string;
    horaEntrada: string;
    horaSaidaAlmoco: string;
    horaVoltaAlmoco: string;
    saida: string;
}