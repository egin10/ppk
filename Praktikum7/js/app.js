const url = 'https://abonsapi.000webhostapp.com/serviceppk';
let Application = {
	initApplication : function(){
		$(window).load('pageinit', '#page-one', function(){
			Application.initShowMhs();
		})
		$(document).on('click', '#detail-mhs', function(){
			let nim = $(this).data('nimmhs');
			Application.initShowDetailMhs(nim);
		})
		$(document).on('click', '#clear', function(){
			Application.clearDetailMhs();
		})
	},
	initShowMhs : function(){
		$.ajax({
		   url: `${url}/web_service.php`,
		   type: 'get',
		   beforeSend: () => {
				$.mobile.loading('show', {
					text: 'Please wait while retrieving data...',
					textVisible: true
				})
		   },
		   success: dataObject => {
				let appendList = dataObject.map(dataMhs => `<li><a href="#page-two?id=${dataMhs.NIM}" target="_self" id="detail-mhs"
					data-nimmhs="${dataMhs.NIM}"><h2>${dataMhs.Nama}</h2><p>${dataMhs.NIM}</p>
					<p><b>${dataMhs.Fakultas}</b></p></a></li>`);
				$('#list-mhs').append(appendList);
				$('#list-mhs').listview('refresh');
		   },
		   complete: () => {
			   $.mobile.loading('hide');
		   }
		});
	},
	initShowDetailMhs : nim => {
		$.ajax({
			url: `${url}/web_service_berparameter.php?nim=${nim}`,
			type: 'get',
			beforeSend: () => {
				 $.mobile.loading('show', {
					 text: 'Please wait while retrieving data...',
					 textVisible: true
				 })
			},
			success: dataObject => {
				 $('#p-nim,#p-nama,#p-jurusan,#p-fakultas,#p-alamat,#p-nohp').empty();
				 $('#p-nim').append(`<b>NIM:</b> ${dataObject.NIM}`);
				 $('#p-nama').append(`<b>Nama:</b> ${dataObject.Nama}`);
				 $('#p-jurusan').append(`<b>Jurusan:</b> ${dataObject.Jurusan}`);
				 $('#p-fakultas').append(`<b>Fakultas:</b> ${dataObject.Fakultas}`);
				 $('#p-alamat').append(`<b>Alamat:</b> ${dataObject.Alamat}`);
				 $('#p-nohp').append(`<b>NoHp:</b> ${dataObject.NoHp}`);
			},
			complete: () => {
				$.mobile.loading('hide');
			}
		 });
	},
	clearDetailMhs: function(){
		$('#detail').remove();
	}
};
