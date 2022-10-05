# -*- coding: utf-8 -*-
"""
Created on Wed Oct  5 14:18:21 2022

@author: ASUS
"""
from pyswip import Prolog

prolog = Prolog()
prolog.assertz("padre(moi,valentina)")
prolog.assertz("padre(valentina,pedro)")
prolog.assertz("padre(erick,pedro)")
prolog.assertz("padre(moi,santiago)")
prolog.assertz("padre(santiago,amanda)")
prolog.assertz("padre(juana,amanda)")
prolog.asserta("abuelo(X,Y):-padre(X,Z),padre(Z,Y)")
prolog.asserta("nieto(X,Y):-padre(Z,X),padre(Y,Z)")
prolog.asserta("hermano(X,Y):-padre(Z,X),padre(Z,Y),X\=Y")
prolog.asserta("primo(X,Y):-padre(Z,X),padre(W,Y),hermano(Z,W),X\=Y")


abuelos = list(prolog.query("abuelo(X,Y)"))

for abuelo in abuelos:
    print (abuelo["X"], " es abuelo de ",abuelo["Y"] )
    
nietos= list(prolog.query("nieto(X,Y)"))

for nieto in nietos:
    print ( nieto["X"], " es nieto(a) de ",nieto["Y"] )
    
primos = list(prolog.query("primo(X,Y)"))

for primo in primos:
    print (primo["X"], " es primo(a) de ",primo["Y"] )

prolog.retractall("padre(X,Y)")
prolog.retractall("abuelo(X,Y)")
prolog.retractall("nieto(X,Y)")
prolog.retractall("hermano(X,Y)")
prolog.retractall("primo(X,Y)")


