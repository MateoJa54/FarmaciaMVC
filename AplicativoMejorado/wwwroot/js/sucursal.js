window.onl
window.onload = function () {
    listarSucursal();
}

let objSucursal;
async function listarSucursal() {

    objSucursal = {
        url: "Sucursal/ListarSucursal",
        cabeceras: ["Id Sucursal", "Nombre", "Direccion"],
        propiedades: ["idSucursal", "nombre", "direccion"],
        divContenedorTabla: "divContenedorTabla",
        editar: true,
        eliminar: true,
        propiedadID: "idSucursal"
    }

    pintar(objSucursal);
}

function filtrarSucursal() {
    let nombre = get("txtNombreSucursal");

    if (nombre == "") {
        listarSucursal();
    } else {
        objLaboratorio.url = "Sucursal/FiltrarSucursal/?nombre=" + nombre,
            pintar(objLaboratorio);
    }
}

function buscarSucursal() {
    let form = document.getElementById("frmSucursal");
    let frm = new FormData(form);

    fetchPost("Sucursal/FiltrarSucursal", "json", frm, function (res) {
        document.getElementById("divContenedorTabla").innerHTML = generarTabla(res);
    });
}

function Buscar() {
    let nombreSucursal = get("txtNombreSucursal");
    objLaboratorio.url = "Sucursal/FiltrarSucursal/?nombre=" + nombreSucursal,
        pintar(objLaboratorio);
}

function Limpiar() {
    listarSucursal();
    set("txtNombreSucursal", "");
}

function LimpiarSucursal() {
    LimpiarDatos("frmSucursal");
    listarSucursal();
}

function GuardarSucursal() {
    let form = document.getElementById("frmSucursal");
    let frm = new FormData(form);
    fetchPost("Sucursal/GuardarSucursal", "text", frm, function (res) {
        listarSucursal();
        Exito("Registro Guardado con Exito");
        LimpiarDatos("frmSucursal");

        var myModal = bootstrap.Modal.getInstance(document.getElementById('modalSucursal'));
        myModal.hide();
    });
}

function Editar(id) {
    fetchGet("Sucursal/RecuperarSucursal/?idSucursal=" + id, "json", function (data) {
        setN("idSucursal", data.idSucursal);
        setN("nombre", data.nombre);
        setN("direccion", data.direccion);

        // Show the modal
        var myModal = new bootstrap.Modal(document.getElementById('modalSucursal'));
        myModal.show();
    });
}
function MostrarModal() {
    LimpiarDatos("frmSucursal");
    var myModal = new bootstrap.Modal(document.getElementById('modalSucursal'));
    myModal.show();
}

function Eliminar(id) {
    fetchGet("Sucursal/RecuperarSucursal/?idSucursal=" + id, "json", function (data) {
        Confirmar(undefined, "¿Desea eliminar la Sucursal " + data.nombre + " ?", function () {
            fetchGet("Sucursal/EliminarSucursal/?idSucursal=" + id, "text", function (r) {
                Exito("Registro Eliminado con Exito");
                listarSucursal();
            });
        });
    });
}
