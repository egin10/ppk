<?php
REQUIRE_ONCE('../koneksi.php');
$QUERY = MYSQLI_QUERY($conn,
"SELECT m.Jurusan AS jurusan, COUNT(m.Jurusan) AS jumlah FROM mahasiswa m GROUP BY m.Jurusan ORDER BY m.Jurusan DESC "
);
$arr = [];
while($ROW = MYSQLI_FETCH_ASSOC($QUERY)){
    $mhs = new stdClass;
    $mhs-> jurusan = $ROW['jurusan'];
    $mhs-> jumlah = $ROW['jumlah'];
    $arr[] = $mhs;
}
header('Content-Type:application/json;charset=utf-8');
ECHO JSON_ENCODE($arr);
MYSQLI_CLOSE($conn);
?>