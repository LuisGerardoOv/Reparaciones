
//const tblCelulares = $('#tblCelulares');
const btncelular = $('#btncelular');
let url = 'https://localhost:44303/Home/GetCelulares';


btncelular.click(function(){
   // getCelular();
    console.log("saliva");
});

function getCelular(){
    tblCelulares.DataTable({
        processing: true,
        serverSide: true,
        search: true,        
        ajax:{
            datatype: "json",
            type: "POST",
            url: url
        },
        columns:[
            {title:"id", data:"id"},
            {title:"Marca",data:"marca"},
            {title:"Modelo",data:"modelo"},
            {title:"Caracteristicas",data:"caracteristicas"},
            {title:"Estado",data:"esReparado"},
            {
                render: function(){
                    let button = "";
                    button = "<button class='btn btn-primary' type='button'><i class='fa fa-pen'></i></button>";
                    button = "<button class='btn btn-danger' type='button'><i class='fa fa-pen'></i></button>";
                    return button;
                }
            }
        ]        
    });
}

//celular