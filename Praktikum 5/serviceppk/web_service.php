<?php
REQUIRE_ONCE('koneksi.php');
$QUERY = MYSQLI_QUERY($conn,
"SELECT * FROM MAHASISWA"
);
$arr = [];
while($ROW = MYSQLI_FETCH_ASSOC($QUERY)){
    $mhs = new stdClass;
    $mhs-> NIM = $ROW['NIM'];
    $mhs-> Nama = $ROW['Nama'];
    $mhs-> Jurusan = $ROW['Jurusan'];
    $mhs-> Fakultas = $ROW['Fakultas'];
    $mhs-> Alamat = $ROW['Alamat'];
    $mhs-> NoHp = $ROW['NoHp'];
    $arr[] = $mhs;
}
header('Content-Type:application/json;charset=utf-8');
ECHO JSON_ENCODE($arr);
MYSQLI_CLOSE($conn);
?>