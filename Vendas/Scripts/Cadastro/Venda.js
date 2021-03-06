﻿function set_dados_form(dados) {
    $('#id_cadastro').val(dados.Id);
    $('#txt_data').val(dados.Data);
    $('#ddl_cliente').val(dados.ClienteId);
    $('#cbx_status_aberto').prop('checked', false);
    $('#cbx_status_fechado').prop('checked', false);

    checkStatus(dados);
}

function checkStatus(dados) {
    if (dados.Status == 1) {
        $('#cbx_status_fechado').prop('checked', true).trigger('click');
    }
    else {
        $('#cbx_status_aberto').prop('checked', true).trigger('click');
    }
}

function set_focus_form() {
    $('#txt_data').focus();
}

function get_dados_inclusao() {
    return {
        Id: 0,
        Data: '',
        Status: 0,
        ClienteId: 0
    };
}

function get_dados_form() {
    return {
        Id: $('#id_cadastro').val(),
        Data: $('#txt_data').val(),
        Status: $('#cbx_status_fechado').is(':checked') ? 1 : 0,
        ClienteId: $('#ddl_cliente').val()
    };
}

function preencher_linha_grid(param, linha) {
    linha
        .eq(0).html(param.Data).end()
        .eq(1).html(param.ClienteId).end()
        .eq(2).html(param.Status);
}

$(document).ready(function () {
    $("#txt_data").mask('00/00/0000');
});