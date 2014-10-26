﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class AnaliseQuestaoDAL
    Public Function ListaAnaliseQuestao(cd_representante As Integer) As DataSet
        Try
            Dim dal As New BDDAL(COMUM.strConexao, True)
            Dim param() As SqlParameter

            param = {dal.CriarParametro("@cd_representante", SqlDbType.VarChar, cd_representante)}

            Return dal.GetDataSet("st_sgs_analise_questao_s", CommandType.StoredProcedure, param)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AlteraAnaliseQuestao(cd_questionario As Integer, cd_status As Integer)
        Try
            Dim dal As New BDDAL(COMUM.strConexao, True)
            Dim param() As SqlParameter

            param = {dal.CriarParametro("@cd_questionario", SqlDbType.VarChar, cd_questionario), _
                     dal.CriarParametro("@cd_status", SqlDbType.VarChar, cd_status)}

            dal.GetDataSet("st_sgs_analise_questao_u", CommandType.StoredProcedure, param)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
