create database if not exists bdtheque character set utf8 collate utf8_unicode_ci;
use bdtheque;

grant all privileges on bdtheque.* to 'bdtheque_user'@'localhost' identified by 'secret';