let dataObject = {
  "mhs": [
    {"nim":"125060400111044", "nama": "Isyana Sarasvati", "jurusan": "Teknik Informatika","fakultas": "Filkom","alamat": "Jl. Suka Nyanyi","noHP": "081234567890"},
    {"nim":"135060401111005", "nama": "Marion Jola", "jurusan": "komunikasi","fakultas": "FISIP","alamat": "Kec. Wakanda","noHP": "08765432109"}
  ]
};

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
		let x = dataObject.mhs.map(m => '<li><a href="#page-two?id='+m.nim+'" target="_self" id="detail-mhs" data-nimmhs="'+m.nim+'"><h2>'+m.nama+'</h2><p>'+m.nim+'</p><p><b>'+m.fakultas+'</b></p></a></li>');
		$('#list-mhs').append(x);
	},
	initShowDetailMhs : function(nim){
		let tbdy = $("#table-detailMhs tbody");
		const dataMhs = dataObject.mhs.find(mhs => mhs.nim == nim);
		const appendDetail = '<tr id="detail"><td>'+dataMhs.nim+'</td><td>'+dataMhs.nama+'</td><td>'+dataMhs.jurusan+'</td><td>'+dataMhs.fakultas+'</td><td>'+dataMhs.alamat+'</td><td>'+dataMhs.noHP+'</td></tr>';
		$('#table-detailMhs').append(appendDetail);
	},
	clearDetailMhs: function(){
		$('#detail').remove();
	}
};