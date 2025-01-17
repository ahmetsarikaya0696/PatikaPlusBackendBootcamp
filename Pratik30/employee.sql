-- test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
);
-- Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
create table employee (
	name VARCHAR(50),
	email VARCHAR(50),
	birthday DATE
);
insert into employee (name, email, birthday) values ('Marvin Upsale', 'mupsale0@skyrock.com', '1981-06-29');
insert into employee (name, email, birthday) values ('Darnell Cicetti', 'dcicetti1@addtoany.com', '1991-11-06');
insert into employee (name, email, birthday) values ('Hazel Lorence', 'hlorence2@illinois.edu', '1983-08-13');
insert into employee (name, email, birthday) values ('Eustace Szachniewicz', 'eszachniewicz3@i2i.jp', '1980-10-05');
insert into employee (name, email, birthday) values ('Maxine Roxbee', 'mroxbee4@merriam-webster.com', '1987-10-10');
insert into employee (name, email, birthday) values ('Nanice Sebborn', 'nsebborn5@free.fr', '1991-05-16');
insert into employee (name, email, birthday) values ('Xaviera Phoenix', 'xphoenix6@prnewswire.com', '2000-01-09');
insert into employee (name, email, birthday) values ('Vivyan Flecknell', 'vflecknell7@squarespace.com', '1994-08-09');
insert into employee (name, email, birthday) values ('Tomi Rolfi', 'trolfi8@mediafire.com', '1999-08-20');
insert into employee (name, email, birthday) values ('Hayley Yoodall', 'hyoodall9@squarespace.com', '1988-11-06');
insert into employee (name, email, birthday) values ('Betty Cicchetto', 'bcicchettoa@engadget.com', '1998-05-18');
insert into employee (name, email, birthday) values ('Launce Kyd', 'lkydb@1und1.de', '1989-07-21');
insert into employee (name, email, birthday) values ('Blondell Gaynes', 'bgaynesc@google.pl', '1994-02-02');
insert into employee (name, email, birthday) values ('Isabel Yitshak', 'iyitshakd@sfgate.com', '1991-06-15');
insert into employee (name, email, birthday) values ('Antonie Aindriu', 'aaindriue@intel.com', '1995-06-01');
insert into employee (name, email, birthday) values ('Maxie Jirsa', 'mjirsaf@cmu.edu', '1989-06-21');
insert into employee (name, email, birthday) values ('Cary Daniells', 'cdaniellsg@bloglines.com', '1998-03-05');
insert into employee (name, email, birthday) values ('Piotr Baudic', 'pbaudich@skyrock.com', '1990-08-26');
insert into employee (name, email, birthday) values ('Evvy Gladwin', 'egladwini@businessweek.com', '1985-11-24');
insert into employee (name, email, birthday) values ('Essa Plunkett', 'eplunkettj@forbes.com', '1982-01-24');
insert into employee (name, email, birthday) values ('Wally Rapport', 'wrapportk@pcworld.com', '1984-07-14');
insert into employee (name, email, birthday) values ('Alister Moffat', 'amoffatl@istockphoto.com', '1994-04-18');
insert into employee (name, email, birthday) values ('Demetri Twitty', 'dtwittym@answers.com', '1990-04-22');
insert into employee (name, email, birthday) values ('Meggie Ducarne', 'mducarnen@ning.com', '1999-02-25');
insert into employee (name, email, birthday) values ('Steffen Songer', 'ssongero@va.gov', '1994-10-19');
insert into employee (name, email, birthday) values ('Cynthia Vaud', 'cvaudp@delicious.com', '1985-03-14');
insert into employee (name, email, birthday) values ('Rafferty Kytley', 'rkytleyq@msn.com', '1995-01-06');
insert into employee (name, email, birthday) values ('Augy Doles', 'adolesr@vistaprint.com', '1998-01-26');
insert into employee (name, email, birthday) values ('Cara Purcell', 'cpurcells@va.gov', '1993-09-19');
insert into employee (name, email, birthday) values ('Marys McLorinan', 'mmclorinant@soundcloud.com', '1993-12-16');
insert into employee (name, email, birthday) values ('Camilla Middell', 'cmiddellu@nifty.com', '1990-11-18');
insert into employee (name, email, birthday) values ('Dodi Carolan', 'dcarolanv@java.com', '1994-08-23');
insert into employee (name, email, birthday) values ('Anallise Bascombe', 'abascombew@feedburner.com', '1996-05-29');
insert into employee (name, email, birthday) values ('Patrizia Boylin', 'pboylinx@1und1.de', '1985-07-21');
insert into employee (name, email, birthday) values ('Sharon Burgett', 'sburgetty@yellowpages.com', '1989-07-24');
insert into employee (name, email, birthday) values ('Aubrey Glackin', 'aglackinz@amazon.co.uk', '1985-08-17');
insert into employee (name, email, birthday) values ('Domingo Luxen', 'dluxen10@bloglines.com', '1983-08-23');
insert into employee (name, email, birthday) values ('Anthe Spera', 'aspera11@yellowbook.com', '1999-11-03');
insert into employee (name, email, birthday) values ('Dulcia Cocher', 'dcocher12@google.es', '1982-12-30');
insert into employee (name, email, birthday) values ('Ruthi Gibby', 'rgibby13@google.it', '1999-12-14');
insert into employee (name, email, birthday) values ('Trish Rizzotto', 'trizzotto14@furl.net', '1991-07-05');
insert into employee (name, email, birthday) values ('Georgie Cuddy', 'gcuddy15@trellian.com', '1980-10-08');
insert into employee (name, email, birthday) values ('Michel Meindl', 'mmeindl16@hostgator.com', '1991-03-28');
insert into employee (name, email, birthday) values ('Shanon Taree', 'staree17@paginegialle.it', '1992-11-27');
insert into employee (name, email, birthday) values ('Daren Dungey', 'ddungey18@exblog.jp', '1984-06-12');
insert into employee (name, email, birthday) values ('Bond Marrett', 'bmarrett19@un.org', '1995-02-02');
insert into employee (name, email, birthday) values ('Cynthia Footitt', 'cfootitt1a@chronoengine.com', '1994-12-28');
insert into employee (name, email, birthday) values ('Osmund Allan', 'oallan1b@t-online.de', '1986-08-18');
insert into employee (name, email, birthday) values ('Orland Gutowska', 'ogutowska1c@google.de', '1994-07-31');
insert into employee (name, email, birthday) values ('Courtnay Bartel', 'cbartel1d@newyorker.com', '1983-12-05');

-- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
UPDATE employee
SET name = 'Ahmet Sarıkaya',
  	birthday = '1996-01-01',
    email = 'ahmetsarikaya0696@gmail.com'
WHERE id = 1;
-- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM employee
WHERE id = 1;