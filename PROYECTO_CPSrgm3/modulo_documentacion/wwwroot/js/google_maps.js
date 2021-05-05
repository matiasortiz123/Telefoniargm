//Muestra en el mapa la direccion seleccionada
function crearMapa(latitud_cliente, longitud_cliente, mapa, title) {
    $('#div_calle').show();
        lat_val = parseFloat(latitud_cliente);
        lng_val = parseFloat(longitud_cliente);
        var mapa = document.getElementsByClassName(mapa)[0];
        map = new google.maps.Map(mapa, {
            center: {lat: lat_val, lng: lng_val},
            zoom: 15
        });
        var marker = new google.maps.Marker({
            position: {lat: lat_val, lng: lng_val},
            map: map,
            title: title
        });
        $('#mapa_manual').prop("checked", false);
        $(mapa).show();
    }

    //Va mostrando las posibles direcciones cada vez que el usuario ingresa una letra en el buscador
    function initializeMultiInputs() {
        var acInputs = document.getElementsByClassName("autocomplete");
        for (var i = 0; i < acInputs.length; i++) {
            var autocomplete = new google.maps.places.Autocomplete(acInputs[i]);
            autocomplete.inputId = acInputs[i].id;
            google.maps.event.addListener(autocomplete, 'place_changed', function () {
                place = this.getPlace();

                var input = $("#" + this.inputId);
                //var input = $("#cliente_mapa_id");
                //console.log(input);
                var input_latitud = $("input[name='" + input.data("latitud") + "']");
                var input_longitud = $("input[name='" + input.data("longitud") + "']");
             //   console.log("latitud" + input_latitud + "longitud" + input_longitud);
                $(input_latitud).val(place.geometry.location.lat());
                $(input_longitud).val(place.geometry.location.lng());
                for (var i = 0; i < place.address_components.length; i++) {
                    var addressType = place.address_components[i].types[0];
                    var value = place.address_components[i].short_name;
                    //console.log("clave: "+ addressType + "valor:" + value );
                    if (addressType == "postal_code") {
                        $("input[name='" + $(input).data("codigo-postal") + "']").val(value);
                        //$("input[name='" + $(input).data("codigo-postal") + "']").attr('readonly', 'readonly');
                    }
                    if (addressType == "street_number") {
                        $("input[name='" + $(input).data("altura") + "']").val(value);
                        $("input[name='" + $(input).data("altura") + "']").attr('readonly', 'readonly');
                    }
                    if (addressType == "sublocality_level_1") {
                        $("input[name='" + $(input).data("barrio") + "']").val(value);
                    }
                    if (addressType == "route") {
                        $("input[name='" + $(input).data("calle") + "']").val(value);
                        $("input[name='" + $(input).data("calle") + "']").attr('readonly', 'readonly');
                        //$("#Calle")
                    }
                    if (addressType == "locality") {
                        $("input[name='" + $(input).data("localidad") + "']").val(value);
                        $("input[name='" + $(input).data("localidad") + "']").attr('readonly', 'readonly');
                        var localidadexterior = value;
                    }
                    if (addressType == "administrative_area_level_1") { 
                        pos_borrar = value.toLowerCase().indexOf("provincia de ");
                        if (pos_borrar != -1) {
                            value = value.substring(13);
                        }
                      var provinciaexterior = value;
                        //if (value == "CABA") {
                        //    $("input[name='" + $(input).data("localidad") + "']").val(value);
                        //    $("input[name='" + $(input).data("localidad") + "']").attr('readonly', 'readonly');
                        //}
                        $("input[name='" + $(input).data("provincia") + "']").val(value);
                        $("input[name='" + $(input).data("provincia") + "']").attr('readonly', 'readonly');
                    }
                    if (addressType == "administrative_area_level_2") {
                        pos_borrar = value.toLowerCase().indexOf("Ciudad de ");
                        if (pos_borrar != -1) {
                            value = value.substring(13);
                           
                        }
                        if (value !="") 
                            $("input[name='" + $(input).data("localidad") + "']").val(value);
                        $("input[name='" + $(input).data("localidad") + "']").attr('readonly', 'readonly');
                        
                       // console.log(localidadexterior);
                    }
                    if (addressType == "country") {
                        if (value != 'AR') {
                            $('.selectLocal').hide();
                            $('.selectExterior').show();
                          //  $('#pais').val(value);
                            $('#Pais').attr('readonly', 'readonly');
                            $('#provinciaStr').val(provinciaexterior).val();
                            $('#localidadStr').val(localidadexterior).val();
                            $("#localidad").empty();
                            $("#provincia").empty();
                    } else {
                        $('.selectLocal').show();
                        $('.selectExterior').hide();
                            
                        }
                        $("input[name='" + $(input).data("pais") + "']").val(place.address_components[i].long_name);
                    }
                    
                }
                crearMapa($(input_latitud).val(), $(input_longitud).val(), input.data("mapa"));
                getData();
            });
         
   //     google.maps.event.addDomListener(document.getElementById('mapita'), 'load', initializeMultiInputs);
        }
        function getData() {
           
            var id;
            var nombre;
            $("#localidad").empty();
            $("#provincia").empty();
            $.ajax({
                type: "GET",
               //url: '/DDJJ/DeclaracionJurada/GetLocalidades?lat=' + $("#latitud").val() + '&lon=' + $("#longitud").val(),
                url: 'https://apis.datos.gob.ar/georef/api/ubicacion?lat=' + $("#latitud").val() + '&lon=' + $("#longitud").val(),
                async: false,
                dataType: "json",
                success: function (data) {
                   //console.log("entra por aca"+data);
                    if (data['ubicacion']['provincia']['id']) {
                        id = data['ubicacion']['provincia']['id'];
                        nombre = data['ubicacion']['provincia']['nombre'];
                        $("#provincia").append('<option value=' + id + '>' + nombre + '</option>');
                        $("#provincia").selectpicker('refresh');
                        $("#provinciadesc").val(nombre)
                    }
                    if (data['ubicacion']['departamento']['id']) {
                        id = data['ubicacion']['departamento']['id'];
                        nombre = data['ubicacion']['departamento']['nombre'];
                        $.ajax({
                            type: "GET",
                            url: '/DDJJ/DeclaracionJurada/GetLocalidades/' + id,
                            async: false,
                            dataType: "json",
                            success: function (data) {
                                var id2;
                                var nombre2;
                                $("#localidad").empty();
                                $("#localidad").append('<option value="">Seleccione </option>');
                                $.each(data, function (key, registro) {



                                    $.each(registro, function (key, value) {
                                        //console.log('keya: ' + key + 'value: ' + value);

                                        //alert(key + ": " + value);
                                        if (key == 'Value') { id2 = value  }
                                        if (key == 'Text') { nombre2 = value  }
                                        if (key == 'Selected') { seleccionado = value }
                                       
                                    })
                                    $("#localidad").append('<option value=' + id2 + '>' + nombre2 + '</option>');
                                });
                              
                                    },
                        
                            error: function (data) {
                                //console.log('error' + data);
                                alert('error');
                            }
                        });
                        
                       
                        $("#provincia").selectpicker('refresh');
                        $("#localidad").selectpicker('refresh');
                        $("#localidaddesc").val(nombre)
                    }
                  
              //      console.log(data);
                //    console.log(data['ubicacion']['provincia']);




                },
                error: function (data) {
                    //console.log('error'+data);
                    alert('error');
                }
            });

        }
} 
