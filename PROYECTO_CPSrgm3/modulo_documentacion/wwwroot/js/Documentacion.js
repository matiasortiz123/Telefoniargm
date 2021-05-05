

$(document).ready(function () {
   
       ///***Editar Contacto ***///
    //if ($('#TipoContactoId').val()==3) {
        
    //        $('#contacto').show();
    //        $('#tel').hide();

    //    } else {
    //        $('#contacto').hide();
    //        $('#tel').show();
    //}

    //$('select[name="TipoContactoId"]').on("change", function () {
    //    let a = $(this).val();
    //    console.log(a)
    //    if (a == 3) {
    //        $('#contacto').show();
    //        $('#tel').hide();
    //    }
    //    else {
    //        $('#contacto').hide();
    //        $('#tel').show();
    //    }
    //})


    ///***Editar Escolaridad ***///
    $("#EscolaridadID").on("change", function () {
        let a = $(this).val();
        if (a <= 4)
            $('#Descripcion').hide()
        else
            $('#Descripcion').show();
})
    
    if ($('select[name="EscolaridadID"]').val() <= 4)
        $('#Descripcion').hide();
    else
        $('#Descripcion').show();    
    
    ///***Fin Escolaridad Editar***///

    /////********////  Fin Editar Domicilio Vivienda /////********////


    /////********////  Editar Familiar  /////********////

    if ($('#Convive').is(':checked')){
        $('.convive').hide();
        $('#domiciliofamilia').find('input:text').val('');
    } else {
        $('.convive').show();
    }

    
    $('#ConviveSi').click(function () {
        $('.convive').hide();
        $('.convive').find('input:text').val('');
        $('#ViveExtranjero').prop("checked", false);
        $('.selectLocal').show();
        $('.selectExterior').hide();
    });
    $('#ConviveNo').click(function () {
        $('.convive').show();
    });
    $('#Vive').click(function () {
        if ($(this).is(':checked')) {
            $('.vive').show();
            $('.defuncion').find('input').val('');
            $('#TituloDomicilio').html('Domicilio');
            $('.defuncion').hide();
        } else {
            $('#Impedido').prop("checked", false);
            $('#TieneIOSFA').prop("checked", false);
            $('.vive').hide();
            $('#TituloDomicilio').html('Lugar de Defunción');
            $('.defuncion').show();
            $('.vive').find('input').not('#ConviveSi').not('#ConviveNo').not('#ViveExtranjero').val('');
            $('#ConviveNo').prop("checked", true);
            $('.convive').show();
            $('#ViveExtranjero').prop("checked", false);
            $('.selectLocal').show();
            $('.selectExterior').hide();
        }
    });
    // FAMILIAR IOSFA
    $('#TieneIOSFA').click(function () {
        if ($(this).is(':checked')) {
            $('.NroIOSFA').show();
        } else {
            $('.NroIOSFA').hide();
            $('.NroIOSFA').find('input').val('');
        }
    });
    $('#Impedido').click(function () {
        if ($(this).is(':checked')) {
            $('.Impedimiento').show();
        } else {
            $('.Impedimiento').hide();
            $('.Impedimiento').find('input').val('');
        }
    });
     /////********////  Familiar /////********////
    ///***Escolaridad Editar***///
    if ($('select[name="ParentescoID"]').val() <= 2) {
        $('#FechaCasamiento').show();
    }
    else {
        if ($('select[name="EstadoCivilID"]').val() > 1) {
            $('#FechaCasamiento').show();
        }
        else {
            $('#FechaCasamiento').hide();
        }
    }
        
          ///***Fin Escolaridad Editar***///
   
        /////********//// Crear Domicilio y Vivienda /////********////
       
    //$('#EditarDomicilioModal').click(function () {
   
    //    initMap();
    //})
        $('#ViveExtranjero').click(function () {
            if ($(this).is(':checked')) {
                $('.selectLocal').hide();
                $('.selectExterior').show();
            } else {
                $('.selectLocal').show();
                $('.selectExterior').hide();
                $('.selectExterior').find('input').val('');
            }
        });
    //$('#Provincia').change(function () {
    //    console.log($(this).children);
    //    var url = '/DDJJ/DeclaracionJurada/GetSubCategory';
    //    var ddlsource = $('#Provincia').val();
    //    $.getJSON(url, { ProvinciaID: ddlsource }, function (data) {
    //        console.log(data);
    //        var items = '';
    //        $("#Localidad").empty();
    //        $.each(data, function (i, localidad) {
    //            items += "<option value='" + localidad.Value + "'>" + localidad.Text + "</option>";
    //        });
          
    //        //$("#Localidad").append(items);
            
    //        $('#Localidad').html(items);
    //        $('#Localidad').selectpicker('refresh');
  
    //    });
    //});
    //$('#EditarDomicilioModal').on('shown.bs.modal', function () {

    //    initMap();
    //    $(":input").each(function (index) {
    //        if ($(this).val() != "")
    //            $(this).attr('readonly', 'readonly')
    //        $('#cliente_mapa_id').removeAttr('readonly', 'readonly');

    //    });
    //})

        $('#AlojaUnidad').click(function () {
            if ($(this).is(':checked')) {
                $('.selectUnidad').show();
                $('#viv_estado').hide();
                $('#viv_alquila').hide();
            }else {
                $('.selectUnidad').hide();
                $('#viv_estado').show();
                $('#viv_alquila').show();
            }
        });
        $('#Alquila').click(function () {
            if ($(this).is(':checked')) {
                $('.Alquila').show();
                $('#viv_alojaUnidad').hide();
                $('#viv_estado').hide();
            }
            else {
                $('.Alquila').hide();
                $("#AlquilaDesde").val('dd/mm/aaaa');
                $("#AlquilaHasta").val('dd/mm/aaaa');
                $('#viv_alojaUnidad').show();
                $('#viv_estado').show();
            }
                    
        });
        $('#OcupaViviendaEstado').click(function () {
            if ($(this).is(':checked')) {
                $('.TiempoOcupaVivienda').show();
                $('#viv_alojaUnidad').hide();
                $('#viv_alquila').hide();
            }
             else {
                $('.TiempoOcupaVivienda').hide();
                $("#TiempoOcupaVivienda").val('');
                $('#viv_alojaUnidad').show();
                $('#viv_alquila').show();
            }
                
        });
    
        $('#ConstruyeVivienda').click(function () {
            if ($(this).is(':checked')) 
                $('.FechaConstruye').show();
            else 
                $('.FechaConstruye').hide();
                $("#FechaConstruye").val('dd/mm/aaaa');
                $("#GuarnicionConstruye").val('');
        });
        $('#ViviendaPropiaSi').click(function () {
                if ($(this).is(':checked')) 
                    $('.Si_Posee_vivienda').show();
                    $('.No_Posee_Vivienda').hide();
                    $('#viv_alojaUnidad').hide();
                    $('#viv_estado').hide();
                    $('#viv_alquila').hide();
                    //$('#formDomicilioVivienda')[0].reset();
                    $('.Input_No_Posee').prop("checked", false);
                    $('.Input_Si_Posee').prop("checked", false);
                    $('.selectUnidad').hide();
                    $('.TiempoOcupaVivienda').hide();
                    $('.Alquila').hide();
                    $("#TiempoOcupaVivienda").val('');
                    $("#SelectUnidad").val('');
                    $("#AlquilaDesde").val('dd/mm/aaaa');
                    $("#AlquilaHasta").val('dd/mm/aaaa'); 
                    $(this).prop("checked", true);
                    $('.FechaConstruye').hide();
                    $("#FechaConstruye").val('dd/mm/aaaa');
                    $("#GuarnicionConstruye").val('');
                    $('.Si_Vivienda_Ocupa_Propia').hide();
                    $('#guarnicion_cercana').show();
            });
        $('#ViviendaPropiaNo').click(function () {
                if ($(this).is(':checked'))
                    $('.No_Posee_Vivienda').show();
                    $('#viv_alojaUnidad').show();
                    $('#viv_estado').show();
                    $('#viv_alquila').show();
                    $('.Si_Posee_vivienda').hide();
                    //$('.Input_No_Posee').prop("checked", false);
                    $('.selectUnidad').hide();
                    $('.TiempoOcupaVivienda').hide();
                    $('.Alquila').hide();
                    $('.Input_Si_Posee').prop("checked", false);
                    $('.Input_No_Posee').prop("checked", false);
                    $('.FechaConstruye').hide();
                    $("#FechaConstruye").val('dd/mm/aaaa');
                    $("#GuarnicionConstruye").val('');
                    $('.Si_Vivienda_Ocupa_Propia').hide();
                    $('#guarnicion_cercana').hide();
                    //$('#formDomicilioVivienda')[0].reset();
                    //14
                    
                    $(this).prop("checked", true);
        });
        $('#ViviendaOcupaPropiaSi').click(function () {
            if ($(this).is(':checked'))
                $('.Si_Vivienda_Ocupa_Propia').show();
                $('.No_Posee_Vivienda').hide();
                $('.Input_No_Posee').prop("checked", false);
                $('.selectUnidad').hide();
                $('.TiempoOcupaVivienda').hide();
                $('.Alquila').hide();
                //$('.No_Posee_Vivienda').find('input:text').val('');
                //$("#TiempoOcupaVivienda").val('');
                //$("#SelectUnidad").val('');
                //$("#AlquilaDesde").val('dd/mm/aaaa');
                //$("#AlquilaHasta").val('dd/mm/aaaa'); 
        });
        $('#ViviendaOcupaPropiaNo').click(function () {
            if ($(this).is(':checked'))
                $('.No_Posee_Vivienda').show();
                $('.Si_Vivienda_Ocupa_Propia').hide();
                $('#Satisface').prop("checked", false);
                $('#PoseeCreditoVivienda').prop("checked", false);
        });
      /////********//// Fin Crear Domicilio Vivienda /////********////


         /////********//// Funcion Captura cualquier select cuando cambia /////********////
        $('.dropdown').change(function () {
            var NombreSelct = $(this).find("select");
            //console.log('codigo: ' + NombreSelct.val() + ' texto: ' + NombreSelct.find('option:selected').text());
            /////********//// Funcion Captura cualquier select cuando cambia /////********////
              /////********//// Situacion Familiar /////********////
            if (NombreSelct.attr('name') == 'SituacionFamiliarID')
            {
                if (NombreSelct.val()==5)
                    $('#Otra').show();
                else
                    $('#Otra').hide();
                    $('#Otra').find('input').val('');
                //   if ((NombreSelct.find('option:selected').text() == 'Otras'))
                //if ((NombreSelct.find('option:selected').text() == 'Otras'))
                //    $('input[name="OtraSituacion"]').parent().removeAttr('class', 'hide');
                //else
                //    $('input[name="OtraSituacion"]').parent().attr('class', 'hide');

            }
            if (NombreSelct.attr('name') == 'EstadoCivilID')
            {
                if (NombreSelct.val() == 2)
                    $('#Fecha').show();
                else
                    $('#Fecha').hide();
                    $('#Fecha').find('input').val('');

            }
             /////********//// Contactos /////********////
            if (NombreSelct.attr('name') == 'TipoContactoId') {
                if ((NombreSelct.val() == '3')) {
                    $('#contacto').show();
                    $('#tel').hide();
                    $('#tel').find('input').val('');
                } else {
                    $('#contacto').hide();
                    $('#tel').show();
                    $('#contacto').find('input').val('');
                }
            }
             /////********//// fin Contactos /////********////

            /////********//// Causas Judiciales /////********////
            if (NombreSelct.attr('name') == 'TipoExpedienteId') {
                if ((NombreSelct.val() == '2')) {
                    $('#Juzgado').html('Organismo interviniente');
                    $('#SituacionJudicial').html('Situación Administrativa');
                    $('input[name="Juzgado"]').attr("placeholder", "Organismo interviniente");
                } else {
                    $('input[name="Juzgado"]').attr("placeholder", "Juzgado interviniente");
                    $('#Juzgado').html('Juzgado');
                    $('#SituacionJudicial').html('Situación Judicial');
                }
            }
               /////********////Fin Causas Judiciales  /////********////

            /////********//// Estudios /////********////
            if (NombreSelct.attr('name') == 'EscolaridadID') {
                if ((NombreSelct.val() <= '4')) {
                    $('#Descripcion').hide();
                 } else {
                    $('#Descripcion').show();
                }
            }
               /////********////Fin Causas Judiciales  /////********////

              /////**** Familia - Tipo de parentesco******/////

         
            if (NombreSelct.attr('name') == 'ParentescoID') {
            //console.log(NombreSelct.val())
                if ((NombreSelct.val() > 1)) {
                    $('.civil').show();
                }
                else {
                    $('.civil').hide();
                }
           }

            /*if (NombreSelct.attr('name') == 'ParentescoID') {
                if (((NombreSelct.val() == '1') || (NombreSelct.val() == '2'))) {
                    $('.conyuge').show();
                } else {
                    if ($('select[name="EstadoCivilID"]').val() > 1) {
                        $('.conyuge').show();
                    }
                    else {
                        $('.conyuge').hide();
                    }
                }
            }

            if (NombreSelct.attr('name') == 'EstadoCivilID') {
                if ((NombreSelct.val() > '1')) {
                    $('.conyuge').show();
                } else {
                    if ($('select[name="ParentescoID"]').val() == 1 || $('select[name="ParentescoID"]').val() == 2) 
                    {
                        $('.conyuge').show();
                    }
                    else {
                        $('.conyuge').hide();
                        $("[name='FechaCasamiento']").val('dd/mm/aaaa'); 
                    }
                }
            }*/

            if (NombreSelct.attr('name') == 'Domicilio.LocalidadId') {
                $('#mantieneLocalidad').remove();
            }

            if (NombreSelct.attr('name') == 'LocalidadEmpleadorID') {
                $('#mantieneLocalidadEmpleador').remove();
            }

            if (NombreSelct.attr('name') == 'LocalidadDefuncionID') {
                $('#mantieneLocalidadDefuncion').remove();
            }
            

            /////**** Familia laboral******/////
            if (NombreSelct.attr('name') == 'SituacionLaboralID') {
               
                switch (NombreSelct.val()) {
 
                    case '1': //Personal Militar
                    case '3':
                        $('.militar').show();
                        $('.amadecasa').show();
                        $('.otros').show();
                        $('.otro').hide();
                        break;
                    case '2':
                    case '4': // personal Civil de la fuerza 
                        $('.militar').hide();
                        $('.amadecasa').show();
                        $('.otros').show();
                        $('.otro').hide();
                        break;

                    case '5':
                    case '7': //Ama de Casa y ninguno
                        $('.otro').hide();
                        $('.amadecasa').hide();
                        $('.amadecasa').find('input').val('');
                        break;
                    case '6': // muestra otros que no pertenecen a la fuerza
                        $('.amadecasa').show();
                        $('.otros').hide();
                        $('.otro').show();
                        break;
                    default:
                }
               
              
            } 
          /////**** Fin Familia******/////
            
         //else {
         //       console.log(NombreSelct.find('option:selected').text());
         //   }
        });

        /////********//// DUFI /////********////
        /////***** Expediente CD *****////
        //$("#TieneExpediente").on("change", function () {
        //    let a = $(this).val();
        //    if (a == "1") {
        //        $('.tiene').show()
        //    }
        //    else {
        //        $('.tiene').hide();
        //    }
        //})
        //$("#ActualizoExpediente").on("change", function () {
        //    let a = $(this).val();
        //    if (a == "1") {
        //        $('.num').show()
        //    }
        //    else {
        //        $('.num').hide();
        //    }
        //})
});
