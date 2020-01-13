create trigger SiparisFaturaOdemeSil on siparis
after delete 
as
begin


delete from fatura  where fatura.siparis_no in (select siparis_no from deleted)
delete from Odeme  where Odeme.siparis_no in (select siparis_no from deleted)
end


--delete from siparis where siparis_no=2