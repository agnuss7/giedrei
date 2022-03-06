from  tkinter import ttk
from tkinter import *
import sqlite3 as sq

ws  = Tk()
ws.title('Veterinarijos zurnalas')
ws.geometry('700x700')
ws['bg'] = '#AC99F2'

con = sq.connect('test.db')
c = con.cursor()

game_frame = Frame(ws)
game_frame.pack()

#scrollbar
game_scroll = Scrollbar(game_frame, orient='horizontal')
game_scroll.pack(side= BOTTOM,fill=X)

game_scroll1 = Scrollbar(game_frame)
game_scroll1.pack(side=RIGHT, fill=Y)


zurnalas = ttk.Treeview(game_frame,xscrollcommand=game_scroll.set, yscrollcommand =game_scroll1.set)


zurnalas.pack(side=LEFT, fill=BOTH)

game_scroll.config(command=zurnalas.xview)
game_scroll1.config(command=zurnalas.yview)

#get fields

c.execute('select f.*,group_concat(j.pavadinimas) from (select a.id, a.reg_data,b.vardas,b.pavarde,b.adresas,c.rusis,c.lytis,c.amzius,c.zenklinimo_nr, a.pastebejimo_data, group_concat(e.pavadinimas),a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id join zurnalas_vaistai xx on xx.zurnalas_id=a.id join vaistai e on e.id=xx.vaistai_id group by a.id) f join zurnalas_tyrimai t on t.zurnalas_id=f.id join tyrimai j on j.id=t.tyrimai_id group by f.id;')

data=c.fetchall()

#define our column
 
zurnalas['columns'] = ('reg_data', 'vardas','pavarde','adresas','rusis','lytis','amzius','zenklinimo_nr','pastebejimo_data','vaistai','bukle','diagnoze','paslaugos','baigtis','tyrimai')

# format our column
zurnalas.column("#0", width=0,  stretch=YES)
zurnalas.column("reg_data",anchor=CENTER, width=180)
zurnalas.column("vardas",anchor=CENTER,width=110)
zurnalas.column("pavarde",anchor=CENTER, width=180)
zurnalas.column("adresas",anchor=CENTER,width=110)
zurnalas.column("rusis",anchor=CENTER, width=180)
zurnalas.column("lytis",anchor=CENTER,width=110)
zurnalas.column("amzius",anchor=CENTER, width=180)
zurnalas.column("zenklinimo_nr",anchor=CENTER,width=110)
zurnalas.column("pastebejimo_data",anchor=CENTER, width=180)
zurnalas.column("vaistai",anchor=CENTER,width=110)
zurnalas.column("bukle",anchor=CENTER, width=180)
zurnalas.column("diagnoze",anchor=CENTER,width=110)
zurnalas.column("paslaugos",anchor=CENTER, width=180)
zurnalas.column("baigtis",anchor=CENTER,width=110)
zurnalas.column("tyrimai",anchor=CENTER, width=180)

#Create Headings 
zurnalas.heading("#0",text="wcfwef",anchor=CENTER)
zurnalas.heading("reg_data",text="Registravimo data",anchor=CENTER)
zurnalas.heading("vardas",text="Laikytojo vardas",anchor=CENTER)
zurnalas.heading("pavarde",text="Laikytojo pavarde",anchor=CENTER)
zurnalas.heading("adresas",text="Adresas",anchor=CENTER)
zurnalas.heading("rusis",text="Gyvuno rusis",anchor=CENTER)
zurnalas.heading("lytis",text="Gyvuno lytis",anchor=CENTER)
zurnalas.heading("amzius",text="Gyvuno amzius metais",anchor=CENTER)
zurnalas.heading("zenklinimo_nr",text="Gyvuno zenklinimo kodas",anchor=CENTER)
zurnalas.heading("pastebejimo_data",text="Ligos pastebejimo data",anchor=CENTER)
zurnalas.heading("vaistai",text="Skirti vaistai",anchor=CENTER)
zurnalas.heading("bukle",text="Gyvuno bukle",anchor=CENTER)
zurnalas.heading("diagnoze",text="Ligos diagnoze",anchor=CENTER)
zurnalas.heading("paslaugos",text="Suteiktos veterinarijos paslaugos",anchor=CENTER)
zurnalas.heading("baigtis",text="Ligos baigtis",anchor=CENTER)
zurnalas.heading("tyrimai",text="Atlikti tyrimai",anchor=CENTER)

#add data 
for t in data:
	zurnalas.insert(parent='',index='end',iid=t[0],text='',
	values=(t[1],t[2],t[3],t[4],t[5],'Patinas' if t[6] else 'Patele',t[7],t[8],t[9],t[10],t[11],t[12],t[13],t[14],t[15]))
zurnalas.pack()

frame = Frame(ws)
frame.pack(pady=20)


ws.mainloop()
