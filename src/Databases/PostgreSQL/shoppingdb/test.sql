-- customers
insert into customers (citizen_number, first_name, middle_name, family_name, phone)
values
('12345678912', 'C ve Sistem Programcıları Derneği', 'CSD', 'C ve Sistem Programcıları Derneği', '+902122883520'),
('12345678914', 'Ali', 'Veli', 'Selami', '+905321234567'),
('12345678916', 'Ali', 'Vefa', 'Serçe', '+905321234567');

-- vendors
insert into vendors (title, description)
values
('HP', 'HP Company'),
('Lokman', 'Lokman Company'),
('Logitech', 'Logitech Company'),
('Microsoft', 'Microsoft Company');

-- products
insert into products (product_code, vendor_id, name, stock, cost, unit_price)
values
('HNY 100', 2, 'Lokman Balları', 0, 200, 300),
('LPT 123', 1, 'HP Elite Book', 120, 4000, 5999),
('MOU 123', 3, 'Logitech Mouse', 1200, 40, 69),
('KYB 101', 4, 'Microsoft Wireless Keyboard', 1000, 100, 249);


-- orders
insert into orders (customer_id, product_code, quantity, unit_price)
values
(1, 'LPT 123', 10, 5999);

-- Stoktaki ürünün siparişe göre güncellenmesi
update products set stock = stock - 10 where product_code='LPT 123';

insert into orders (customer_id, product_code, quantity, unit_price)
values
(1, 'MOU 123', 20, 69);

-- Stoktaki ürünün siparişe göre güncellenmesi
update products set stock = stock - 20 where product_code='MOU 123';

insert into orders (customer_id, product_code, quantity, unit_price)
values
(3, 'MOU 123', 10, 69);

-- Stoktaki ürünün siparişe göre güncellenmesi
update products set stock = stock - 10 where product_code='MOU 123';

insert into orders (customer_id, product_code, quantity, unit_price)
values
(2, 'KYB 101', 10, 69);

-- Stoktaki ürünün siparişe göre güncellenmesi
update products set stock = stock - 10 where product_code='MOU 123';

-- Sorgulama örnekleri

-- Tüm ürünleri tüm bilgileriyle getiren sorgu
select * from products;

-- Tüm ürünleri ürün kodu, ürün adı ve birim fiyatı ile birlikte getiren sorgu
select product_code, name, unit_price from products;

select product_code as "Ürün Kodu", name as "Ürün İsmi", unit_price "Ürün Birim Fiyatı" from products;

select product_code as code, name, unit_price as price from products;

-- Stokta bulunan ürünleri code, name ve price bilgisi ile getiren sorgu
select product_code as code, name, unit_price as price from products where stock > 0;

select p.product_code as code, p.name, p.unit_price as price from products p where p.stock > 0

-- product-code bilgisi belli olan ürüne ilişkin sipariş verenlerin bilgileri getiren sorgu

-- inner join
select c.first_name, c.family_name, c.phone, o.quantity, o.unit_price, o.quantity * o.unit_price as total
from orders o inner join customers c on o.customer_id = c.customer_id
where o.product_code='MOU 123';

select c.first_name, c.family_name, c.phone, o.quantity, o.unit_price, o.quantity * o.unit_price as total
from customers c inner join orders o  on o.customer_id = c.customer_id
where o.product_code='MOU 123';


-- kartezyen sorgu (self join)
select c.first_name, c.family_name, c.phone, o.quantity, o.unit_price, o.quantity * o.unit_price as total
from customers c, orders o
where o.customer_id=c.customer_id and o.product_code='MOU 123';

-- Müşteri id numarası bilinen müşterinin verdiği siparişlere ilişkin ürünlerin bilgisini getiren sorgu
update products set unit_price = unit_price + unit_price * 0.25;
update products set unit_price = unit_price - unit_price * 0.75;

select p.name, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from orders o join products p on o.product_code = p.product_code
where customer_id=1;

-- Aşağıdaki sorguda her bir ürün için kar-zarar durumu çıkartılmıştır
select p.name,  p.unit_price * o.quantity - o.unit_price * o.quantity as status
from orders o join products p on o.product_code = p.product_code
where customer_id=1;

-- citizen_number'ı bilinen müşterinin verdiği siparişlere ilişkin ürünlerin bilgisini getiren sorgu
--inner join
select p.name, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from
customers c inner join orders o on c.customer_id = o.customer_id
inner join products p on o.product_code = p.product_code
where c.citizen_number='12345678912';

-- Tabloların birleşimde önemli olan sırası değil birleştirilecek alanlardır
select p.name, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from
orders o inner join customers c on c.customer_id = o.customer_id
inner join products p on o.product_code = p.product_code
where c.citizen_number='12345678912';

-- kartezyen sorgu (self join)
select p.name, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from customers c, orders o, products p
where c.customer_id = o.customer_id and o.product_code = p.product_code and c.citizen_number='12345678912';

-- Müşteri id numarası bilinen müşterinin verdiği siparişlere ilişkin ürünleri vendor bilgileri de olacak şekilde getiren sorgu
select p.name, v.title, v.description, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from
orders o join products p on o.product_code = p.product_code
inner join vendors v on v.vendor_id=p.vendor_id
where customer_id=1;

-- citizen_number'ı bilinen müşterinin verdiği siparişlere ilişkin ürünlerin bilgisini getiren sorgu
--inner join
select p.name, v.title, v.description, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from
customers c inner join orders o on c.customer_id = o.customer_id
inner join products p on o.product_code = p.product_code
inner join vendors v on p.vendor_id = v.vendor_id
where c.citizen_number='12345678912';

-- kartezyen sorgu (self join)
select p.name, v.title, v.description, o.quantity, o.unit_price, o.unit_price * o.quantity as total, p.unit_price as currrent_price
from customers c, orders o, products p, vendors v
where
c.customer_id = o.customer_id and o.product_code = p.product_code and v.vendor_id = p.vendor_id
and c.citizen_number='12345678912';

