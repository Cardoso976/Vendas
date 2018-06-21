$(document).ready(function () {
    listaDeClientes();
});

function listaDeClientes() {
    $.ajax({
        url: url_listar,
        type: 'GET',
        datatype: 'json',
        success: function (clientes) {
            listaClientesSucesso(clientes);
        },
        error: function (request, message, error) {
            handleException(request, message, error);
        }
    });
}

function listaDeCliente(id) {
    $.ajax({
        url: url_getCliente + '/' + id,
        type: 'GET',
        datatype: 'json',
        success: function(cliente) {
            listaClientesSucesso(cliente);
        },
        error: function(request, message, error) {
            handleException(request, message, error);
        }
    });
}

function listaClientesSucesso(clientes) {
    $.each(clientes, function (index, cliente) {
        clienteAddRow(cliente);
    });
}

function clienteAddRow(cliente) {
    $("#clienteTable tbody")
        .append(clienteBuildTableRow(cliente));
}

function clienteBuildTableRow(cliente) {
    var ret =
        "<tr>" +
        "<td>" + cliente.Nome + "</td>" +
        "<td>" + cliente.Email + "</td>" +
        "</tr>";
    return ret;
}

function handleException(request, message,
    error) {
    var msg = "";
    msg += "Code: " + request.status + "\n";
    msg += "Text: " + request.statusText + "\n";
    if (request.responseJSON != null) {
        msg += "Message" +
            request.responseJSON.Message + "\n";
    }
    alert(msg);
}

$("#btn_incluir").click(function () {
    $.ajax({
        url: url_adicionar,
        type: 'POST',
        data: get_dados_form(),
        success: function () {
            showNotification('top', 'right');
        },
        error: function (request, message, error) {
            handleException(request, message, error);
        }
    });
});

function showNotification(from, align) {
    $.notify({
        icon: "ti-gift",
        message: "Welcome to <b>Paper Dashboard</b> - a beautiful freebie for every web developer."

    }, {
            type: "success",
            timer: 2000,
            placement: {
                from: from,
                align: align
            }
     });
}

function get_dados_form() {
    return {
        Nome: $('#txt_nome').val(),
        Email: $('#txt_email').val()
    };
}