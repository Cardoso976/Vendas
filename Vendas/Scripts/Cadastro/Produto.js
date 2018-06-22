function set_dados_form(dados) {
    $('#id_cadastro').val(dados.Id);
    $('#txt_descricao').val(dados.Descricao);
    $('#txt_preco_custo').val(dados.PrecoCusto);
    $('#txt_preco_venda').val(dados.PrecoVenda);
}

function set_focus_form() {
    $('#txt_descricao').focus();
}

function get_dados_inclusao() {
    return {
        Id: 0,
        Descricao: '',
        PrecoCusto: 0,
        PrecoVenda: 0
    };
}

function get_dados_form() {
    var form = new FormData();
    form.append('Id', $('#id_cadastro').val());
    form.append('Descricao', $('#txt_descricao').val());
    form.append('PrecoCusto', $('#txt_preco_custo').val());
    form.append('PrecoVenda', $('#txt_preco_venda').val());
    return form;
}

function preencher_linha_grid(param, linha) {
    linha
        .eq(0).html(param.Descricao).end()
        .eq(1).html(param.PrecoCusto).end()
        .eq(2).html(param.PrecoVenda);
}

function salvar_customizado(url, param, salvar_ok, salvar_erro) {
    $.ajax({
        type: 'POST',
        processData: false,
        contentType: false,
        data: param,
        url: url,
        dataType: 'json',
        success: function (response) {
            salvar_ok(response, get_param());
        },
        error: function () {
            salvar_erro();
        }
    });
}

function get_param() {
    return {
        Id: $('#id_cadastro').val(),
        Descricao: $('#txt_descricao').val(),
        PrecoCusto: $('#txt_preco_custo').val(),
        PrecoVenda: $('#txt_preco_venda').val()
    };
}

$(document).ready(function () {
    $('#txt_preco_custo,#txt_preco_venda,#txt_preco').mask('#.##0,00', { reverse: true });
});