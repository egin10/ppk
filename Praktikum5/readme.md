```
CREATE TABLE `mahasiswa` (
`NIM` varchar(15) NOT NULL,
`Nama` varchar(100) NOT NULL,
`Jurusan` varchar(100) NOT NULL,
`Fakultas` varchar(100) NOT NULL,
`Alamat` varchar(100) NOT NULL,
`NoHp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
ALTER TABLE `mahasiswa`
ADD PRIMARY KEY (`NIM`);

INSERT INTO `mahasiswa` (`NIM`, `Nama`, `Jurusan`, `Fakultas`, `Alamat`, `NoHp`)
VALUES
('125060400111044', 'Isyana Sarasvati', 'Teknik Informatika', 'Filkom', 'Jl. Suka
Nyanyi', '081234567890');
```

buat sebuah database baru dengan nama `servisppk`, kemudian jalankan perintah sql diatas untuk membuat table baru dan menginputkan data baru.
letakan folder `serviceppk` di xampp/htdocs.
tinggal buat laporan.