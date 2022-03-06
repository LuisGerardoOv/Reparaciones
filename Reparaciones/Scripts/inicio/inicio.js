let url = 'https://localhost:44303/Home/GetCelulares';  
let urlGuardar = 'https://localhost:44303/Home/GuardarCelulares';   

const tblCelulares = $("#tblCelulares");
const btnNuevo = $('#btnNuevo');
const txtMarca = $('#txtMarca');
const txtModelo = $('#txtModelo');
const txtCaracteristicas = $('#txtCaracteristicas');
const btnGuardar = $('#btnGuardar');
let dtCelular;

$(document).ready(function(){
    getCelular();
});  

function AddRows(tbl, lst) {
    dt = tbl.DataTable();
    dt.clear().draw();
    dt.draw();
    dt.rows.add(lst).draw(false);
}

function getCelular(){
    dtCelular = tblCelulares.DataTable(
        { 
        destroy: true,
        ordering: false,
        language: 'dtDicEsp',
        searching: true,
        paging: true,  
        ajax:{
            url:url,  
            type: "POST",           
            success: function(response){    
                 AddRows(tblCelulares, response);    
            }                 
        },              
        columns:[
            {title:"id", data:"id"},
            {title:"Marca",data:"idMarca", visible: false},
            {title:"Marca",data:"marca"},
            {title:"Modelo",data:"modelo"},
            {title:"Caracteristicas",data:"caracteristicas"},
            {title:"Estado",data:"esreparado"},
            {
                title: 'Operaciones', width: '7%',
                render: function(data, type, row){
                    let button = '';
                    button += `<button class='btn btn-primary editar' type='button' data-id="${row.id}"><i class='fa fa-pen'></i></button>&nbsp`;
                    button += `<button class='btn btn-danger eliminar' type='button' data-id="${row.id}"><i class='fa fa-trash'></i></button>`;
                    return button;
                }
            }
        ],    
        initComplete: function (settings, json) {
            tblCelulares.on("click", ".eliminar", function () {
               console.log("si entra");
              
            });
            tblCelulares.on("click", ".editar", function (e) {
                const rowData = dtCelular.row($(this).closest("tr")).data();
                console.log(rowData.id);
                $('#modalCelulares').modal('show');
                txtMarca.val(rowData.idMarca);
                txtModelo.val(rowData.modelo);
                txtCaracteristicas.val(rowData.caracteristicas);                
                btnGuardar.attr("data-id",rowData.id);

            });
        }  
    });
}

btnGuardar.click(function(){
    GuardarCelulares();
});

function getParametros (){
    let parametros = {
        id: btnGuardar.attr('data-id'),        
        idMarca: txtMarca.val(),
        modelo: txtModelo.val(),
        caracteristicas: txtCaracteristicas.val(),        
    }

    return parametros;
}

function limpiarInputs (){
    txtMarca.val('');
    txtModelo.val('');
    txtCaracteristicas.val('');
}

function GuardarCelulares(){
    let nuevoCelular = getParametros();    
    console.log(nuevoCelular);
    $.ajax({
        url:urlGuardar,data: {nuevoCelular: nuevoCelular},  
        type: "POST",           
        success: function(response){ 
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Se guardo correctamente',
                showConfirmButton: false,
                timer: 1500
              })
              limpiarInputs(); 
              $('#modalCelulares').modal('hide');      
              getCelular();    
        }           
    });
}

//INICIO
        




 

    

    
    