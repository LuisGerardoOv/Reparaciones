let url = 'https://localhost:44303/Home/GetCelulares';   
const tblCelulares = $("#tblCelulares");
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
            {title:"id", data:"id", visible: false},
            {title:"Marca",data:"idMarca", visible: false},
            {title:"Marca",data:"marca"},
            {title:"Modelo",data:"modelo"},
            {title:"Caracteristicas",data:"caracteristicas"},
            {title:"Estado",data:"esreparado"},
            {
                title: 'Operaciones', width: '7%',
                render: function(){
                    let button = '';
                    button += `<button class='btn btn-primary' type='button' ><i class='fa fa-pen'></i></button>&nbsp`;
                    button += `<button class='btn btn-danger' type='button'><i class='fa fa-trash'></i></button>`;
                    return button;
                }
            }
        ]        
    });
} 

//INICIO
        




 

    

    
    