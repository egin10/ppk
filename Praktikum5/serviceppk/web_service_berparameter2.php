<?PHP
REQUIRE_ONCE('koneksi.php');
if(isset($_GET['Nama'],$_GET['Jurusan'])){
$QUERY = MYSQLI_QUERY( $conn,
'SELECT * FROM `MAHASISWA` WHERE Nama like "%'.$_GET['Nama'].'%" OR
Jurusan like "%'.$_GET['Jurusan'].'%";'
);
$mhs = new stdClass;
$ROW = MYSQLI_FETCH_ASSOC($QUERY);
$mhs-> NIM = $ROW['NIM'];
$mhs-> Nama = $ROW['Nama'];
$mhs-> Jurusan = $ROW['Jurusan'];
$mhs-> Fakultas = $ROW['Fakultas'];
$mhs-> Alamat = $ROW['Alamat'];
$mhs-> NoHp = $ROW['NoHp'];
header('Content-Type:application/json;charset=utf-8');
ECHO JSON_ENCODE( $mhs);
MYSQLI_CLOSE($conn);
}
else {
echo '404: apakah itu 404? apa hayo?! error lah pokoke';
}
?>