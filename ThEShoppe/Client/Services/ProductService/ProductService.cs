using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
       

        public void LoadProducts()
        {
            Products = new List<Product> {
        new Product {
            Id = 1,
            CategoryId = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "2005 (Sci-Fi, Comedy)",
            Image = "http://3.bp.blogspot.com/-beczHRK7TFw/UWTsjPEiy9I/AAAAAAAAHMI/HablT3KwK18/s1600/the-hitchhikers-guide-to-the-galaxy-50bfe66186fa0.jpg",
            Price = 9.99m,
            OriginalPrice = 19.99m,
           },
        new Product {
            Id = 2,
            CategoryId = 1,
            Title = "Scarface",
            Description = "1983 (Crime, Drama)",
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6363/6363964_sa.jpg;maxHeight=640;maxWidth=550",
            Price = 29.99m,
            OriginalPrice = 39.99m,
        },
        new Product {
            Id = 3,
            CategoryId = 7,
            Title = "Crazy Rich Asians",
            Description = "2018 (Romance, Comedy)",
            Image = "https://upload.wikimedia.org/wikipedia/en/b/ba/Crazy_Rich_Asians_poster.png",
            Price = 19.99m,
            OriginalPrice = 19.99m,
        },
        new Product {
            Id = 4,
            CategoryId = 5,
            Title = "Spectre",
            Description = "2015 (Action, Adventure)",
            Image = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBISEhISEhERGBgYGBIZEhgYERIYGBEYGBgZGRgaGBgcIy4lHB4rHxgYJjomKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHhISHDQhJCs0NDQ0NDQ0NDExNDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ/NDQ/NP/AABEIAMIBAwMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAAAAQIEBQYDBwj/xABEEAACAQIEAwUFBQUGBAcAAAABAgADEQQSITEFQVEGEyJhcTKBkaGxBxRCUsEzYnKS0SOisuHw8SRDgtIVFjREY3PC/8QAGQEBAQEBAQEAAAAAAAAAAAAAAAECAwQF/8QAIhEBAQACAgMAAgMBAAAAAAAAAAECERIxAyFBMmETInEE/9oADAMBAAIRAxEAPwDzCLCE9LylE6CcxHCEp8jVNzJEkYLhxqNflpM5ZST21hjbdRXQmqxPY/FFQ9NKZva6hgCPjaZ3G4OpSbI6FTzFwR7iNJjHOWuuXjuMR4QtACbcxCDjKbNoeh0MIXQhFhCEigRbR00OlPaPnNDHZh1hzpYsQQhCxYkWAXhCEAhCJALwiQgEIQhokQxYkAhCEBloWjrQtCkAjhEAiO9tBAkUKL1GCIpZjsBuZs+zGEUKGYWub+LQL0veZXsvjBTxlFnIyksj5tsrqR7tbT07gBR86sEZM9QoTZhYMbWPPaefzX49Xgxna3oV6Xdk51sPaJ8OX1vPPO2mHQ5nFtdufObmu9N3FO4F3sqFSLqiNcjTa53mS7TYCm2an3j2VXd3LDwKtrC55ZiBznLHuO+f4150JfJwcpSVzUVC18xJ19F/rK7g2G7yqgOwIJm74p2VeuiVKFQXBK5WHhCr7RHRr3M7eTLXp5/FhvdZql2dNRlXDZ3c/hbXP+YnoPOL2h7F18KhqgJoLuisWt15a+6em8D4AMHQY08z1CLu11u1tlW+gHrKvtFjXGDqPWRwCXRcwQNfKScxXSw6znjlfjvcMde3ka6gHa8cBLLjKragUt+zQPbYMLm3rr85WgGenG7m3izmrooEUCJYxQDNMhhG5TH5TDIYTYUETrGKnWPhmiLCEIIQiQJRxS6f2a/LX5SQCrLfLTF7aeG+3pK2IZm4tzKrcql7Wpa3IPhsu8a6Uzrlp7gb28r6fGVNoknD9tcv0tqppqATk0v7IBz3G0r8R7ZsANtAbgaTjCaxx0zllssSEJUEIQgOtEtHQgMbYyPJc4vRO4ksXGuE9C7GcTHdU6NTwEZlpvfR9dLHkw6TH8M4JicSwFKk5FwC+U5Ev1bb3DWWS8Wdan3X7irKgVBTRWNQFNM5bLdmJ1uV6TnnOU09HivG7ek47PTVSalwATuDa/ny+JnmfaDixrPUSmylDkBI/HkJNgfy5jf3COr8a7qogbBO1iC1PEvVKv8Au91ZRY9TeaXtd2Rq1MmLwtO3eKjVKIAujH8mg2FgRYbXmcMNXda8udymozPZevTpVlepoozHboNPnN1wPiz1CzKTlIICZeaeLw9SUz7dJgqBqUXFOvhWOmgdGUq3M6jnbabTgSVy9Ko6KiU85przJYWuRy0PynLy/lt08P46bfBYlHUMjggjrMH2347TqWwea4Zj3l6VRWphfFdCbBtRb3yViMJj/vL1sEiKmUNVSoxVGJP4dPaOug3tfnrj+NtiatZq1eitN1BBQA6KPx3O99Rfylxxs7ayzll0p67hFZALhipzEWNlvbL85GVxB2LG593kOkbaenGajw5Xd265xvGq+kkUMGQMz6Aa/wC8j4gg6geXrNMeq60nvc2ix6USKaP+YuPhaMMJ9JFiQhSwiRYZESESARIsQw0IkIQCEIQCEIQCEIQH3hGxYGl7Hdmvv1R8xZUTQlbXLHa19gJ6RgOwuCojP3Idhrdyz7b6E2HwjuwmBp4XB0jUdAXAZiWA8Ta215zW03VrlSCOoII1nHLL29GGMk9xW08IAFVVUAbWFh7hJWCwVNXaoKaByB48ozEC+mbfnO6U7afD0nRFsZNtq/i/AMJijTqV6Ku9NlamxuGUqcwGYHVbjY3Ex3b0cVZ6dLAUqpQqzVXQpdmJK5CWPhsLHTfN5T0RhpKfjfHsNglV67nxMFVEUu7G1zZF1sACSYWXXtjvs74djGGIp8Rp1CA1NqZrKHvcOGVGJOmin4dZrn4ZTpnvEVRl1ym+U2+kqsP9oHCh4TiwrbsHo4hLFtfxJtr8BJz9quHVVKpjcM2m3eqDr5G0ndLa7IwcKy/iAY+f4R8hMr24wqmlnyAlfjYmx/15SV2a43SqO1NXByXVdhdQ2495MmdrKd6D2/LcfXSZytmW1wkvj08eKUb/ALM/E/SS8LhVOyATq+EYPUDoVZQzFTy52k3DULW/jK7eRInrfPVPG0yooH4jr7he0h4XDAX7xLiyMNTs17WtNQ+Hvvtmy5coIva4JvIfFXNNRma4OgFhc26eWsi/FXxLEAolMUwoBLLbptKwzvisQahBtYAWE4QsJFiQhSwiQgESEIBEixIBCEIBCEIBCEIBCEIAJP4NgXxGIo0UXMXdRbyvdifIKCZBE2f2WMg4gM3td1U7v1ut/fa/zkvS4zd03XEOD1VcZvEir/ZgDwptfp4jYc4uExT0mz09Ts6m+vk3Me+/kZs7QsvQTzXH3t7Zl61pFwGPp10DpfzB3U8wZMLCMBHKKDrNMIPFOL91dEpu72BUWsuuxLdPSYKpwKnUrPisUiNUdrsTpY2sOegtymj7T42qldEp4XEVMyC7pTZ1U5iAGI0BlYnCcZXqAtTdAObnKB6dfcJi726Y8dMXieDtjatTC0cJTIubVUCKyBDYM+ciy7bE3HKaKt9lvD6VI5mxLvbVzUUWPOyhbW8jebHs/wBnFwrVHZw7vucgsguSQpOpBNr+gnXtFXSnhqrsbBUc+9QTb/XWdMdueTw3/wAsor0VasLO7LcAhlFyFJ1tqbD3z0rhfABhcC9EVXqZmdiXN8pZQoVegso95MoOzfB3xdHE1WHiWiRQB/DUb+0X3jKvxms4PjhXwyOPxIp9LiPIngsu3n9TiiVK7rUst0KuehXQ6/GTRiqN7B9cwOitodAAdNL/ADvK3jvD6lLEYipTemoa+je0QwBNri28jVRjxmJdD7BazJuPZG2+gnXG7krzZ46ysXn3qndtXF2S90cZWFrA6aE6aSq7R1UemPazK+xRha41Bv7jIY4hjEJV1e2cFiEz+IAEAEabAThxHiNaogSoAASGHhte2k0wrTG3gYkNFhEiQFvCJCAsSEIBCEIBCEIBCEIBCESFEIQgOEtOz3EfuuKo19bI4z+aHwt8iT7pVidFhN6r3mp2ywKqpOKQ3AIAux+AGkj1O3GCAv3p/lGvpczw8sBJfC+B4rGVMlGixtbOTZVS+2Zj9N5zyxkdcfJbenrD/aTgQQqtUYde6ffp0995zf7T8Gt7pXY9VpgD+8ZTcI+y3MAcViSv7tJV+buD9JdVvsxw+W1PF4oabN3bj5ATPp0nJfcC4+MZTNanTKJ/y2d0zVCCQ/gHsgEEa729JbfeLb/7TL4PsKKaIi8Qxgy7AGnkU3v4UKmwvrH4rsxigpNPilcvyzpTK/3ZFahK4P8AvoZiftS4mKWENJfbrsEQe7xN6AfpMp2ip8awYao1Z3TnUpspVf4lsCvra3nMPiuJYrEuHr1XqECyljooOtgBN44/WcstR7D2Zx6ph6NCgt2CgnX22/EzHkL8/htrVdmMS1KpiMJUtnp1agFgQoVjnW1+VmFpT9jOIGiXdtWKhfnc/QAekteKlkxdPGBfBWC06x5JUW/dsf4gcvqB1l8uO8XPwZSZ6qV2jwmi1e7VmHhF7c9tT5zFYp7XWohQ3u2Q3U9L5t/dPQOJAVcO6GxupFjsdJlkr0yLaemmnpMeHL1p0/6cdZTJnS51yO4AJPssDcjXY9JX4msXa5ZjbQE72mgxFemO8tplRrebMPrt8ZmZ2eaCJCEKIQhAIQhAIQhAIQhASEIQCEIQCEIQCEIQHLO60wqh22/CObn+nnG4alnYDlzPQDUxzk1qgVdB7KdFUc4C4asoY1HANvYXlfl7hPXPs6p1hgw5pqDUd6mdnAzhjZTlA0GUC1zPHzRzVDTp3a5smmrdJ9E8Kwgo0KdMbIiKP+kATGV9OninvaTSzAeLL7r/AKzs1YKLm9rgaAm1/Sc7xBVI16azk7oPAuJGvTd9TavjEvYmwSu6qPLw5ZPdjrMV9lOO7zBVSTc/ea7fz2f9ZtGN5RBxFZ7EdyzA3B1QgjzBnjva3hy0sW4p0GpI9nVCoAGlmyW0y3BOnWe2FJhPtLwl/u1W2xqIfeAw/wALTWF9ufkn9WW4FQLMFHMienrwym2GejUGZXWzfUEHkQQCDyIEw/ZLCl6gPIT0DFVQlM3PKdq8kvvbHYGqwV6Tm7ISrH84/C3vGvlqOU8+43TanXqKCQL3HodZp8dxFaeJNS+m1T+G+/uvf4yv7Y4YMKddNjofTl/rznCTjl/r23L+Tx7+xli5ta589TrGRTEnZ5hCEIUQhCEEIRICwiQgLEhCAQhCAQhCAQhGmAQhCFPFRlvY7gg+hksqaVMC3jqAeqpyA8yZDUZmYnbxE+g2/QRULswsWLaW1JMDTdnBTp4ihRAzO70xUI2TW5W/kAdp7mnszxbsNwxRjqRqOC6io+Qa2strk/8AVPaEew2nLJ18c9EBkDjGJ7vDYmpySjWf+VGP6ScTMx9omMWlwzFm+roKa+rkKfleZdWQ+xXGW+94c9KVVf8AA/1T4z1JnsZ4R9mWPFHidIE2FVXpH1azL/eUT3YrF7ZnRO9md7dpmwbE7q6N87H5NNEunKVPaGn3lGpT/Mj/AE0lx7MpuKPsYFSn3jc7ztx7iIKtYyo4Ojfd1tfcyu40zqp3noeLSgxFTO735g/WWgTvOFoc1yM6+9GYf/kSiU6VW6L9TO+AxT08HlOUhmZwDuE6+9mE5eSdPX4fsUl4QMSbcSxJa8NRGpkU6dF6ubVarWunLuwWAJ63N9RaQ+JKBUI7lqVguZCTo1vERfZSdt5nl70uvW0aEucMn9hRZMLTqsz1Ea9OoT4cmW5U6e0fhIHFadNKrrT0AsGXNmCONHRW/Eoa9m5xMt3S3H0ixLzRHDORSNPB4Zw9OmxJIBzsPEts4Py5yko0+9qqi2QO9hc6IGPXoB9ImWy46cYSyr4ulTdqaYSmUUlb1M/ePbTMWBGQnewGkr0qAPmCKRe+Rrstuh5mJUsNhLl8RTFFKpwuHOZ6iEBagsFVSCDm0Pi+UgcJQNXpIwVgzqrBhcG+m3vvEy9FxRYS7egClbvcKlJUDZHVaiHPchAFYkOCRqBsNZU4S3eU7qCC6Agi4ILAG/xiZbLjpyjZf4+i6d7fB4fIucB1YZgt8quAHPVTtKCWXaWaESEJQQhCAitZSOpF/Qf5/SWT1O5pqq2zsLk8xK+gviBOw19bf5wd2drk6n5TKtH2N4smFrVcRUSo9qZAKZbg5gWvmIvou03VD7VuHEAFcUOv9kv6MZ5bisSqU2poNSpDHoDv75RiZym3TC6j3RvtM4Zyq1ffQqf0mE+0PtimPFOjQzd0hLOxBHeNay2U62UFt+Z8phjEMzpvbrSqsjK6EqylWVhurKbgj0IE9y4V9oeBq00epXWk9h3iMGGVueU2sVvPDalHKAfS/kZzEtm0le+VvtA4av8A7pG/hVz9BKqp9oGAqOEVqr3vtSYDb9608YnXCPlqI3Rl+ZsfrEi7e3cDVWo3W+UklbjW19LyB2qpBacldknvhk8iw+DGQ+19TNmHJROzyfXn1Z7U6vmaY/xk/ScCCULMxJ8IOvIXsPQRaz3Rh1dD8Ff+sZSBbw3tuR5kDaSx03ZNRzMSLEhEjDVKIBWrSdtbqyVAjLpsQQQRDH4s1XDWyqoC01vmyINhmOp1JOvXpIsJnXtd/E0Y5hRp00Z0KvULFXZQ6uFsDY8iG+MhQiRIbWbYzDuKfeUKhZEppmWsq3yCwNshsffK+tlLNlvluct98t9L+doyTsDwupWQupQC7KuYm9RlQuVWwOyi9zptHrFfdd6nEaVRhUrYdney5itXIlUgWDOuW4OgvY6ysdgSSBYEmwuTlHS53lr/AOAVAUVnpAs2QL42YPZTksq6kBwSRoLG50nPHcJ7lbviKBJzZVXvGLW05LYX6kzMs+Fl+o74oGglKxur1HvpYhlUfHSMwNYU6lOowuFZWI6gHUSPFvN6TaeMcGWpTqZmViWpkm7UWubEX/CRYFb8vKQ6NTK6Nb2WVrdcpBt8pzvCSTRtZ18VhXao3c1kZy5uKykKzEn2cguL8rysheESaLdiJeESaQt4RLwhSs5awA02EehCg23A1P6CNQ6AfGI730G31mVcqh8JkWSah8JkaStY9FjqCXYeWsZJOGXcyTtbdRIdbgjrK6WKjUCR8fTC1DbY2I981WcajQU6g+YixJht7L2TqAYOmer1PgCSfpK7tNVth2c7sTb4x3Ztz9zRed3C+rt/QGQu3tTIlGkOlzO7zfWLBup/iH0MS8EGhHofrEGukzWyxJLoYQlrOrAW/X/edEwiEkWfy0O++9ulpm5SNTGq6EsmwaAm4flbzJ5besPulO5Hj0vff62tzk5w4VWQlj9wUWJL2v4vDa2/6xjYelci9QXtkura8trdY5w41Bk/CcXqUqfdoE3fKxBLIHy5wNba5Bra9r9Y8YGn4fb1vrbf0guCpkt+0sNB62vrpppaS5Y1ZjYfU4/VbN4Ka3WooyhwU7xs1RlbNcMx3PTQSrZidSST1JJlg+BpixOcCxzabHS1tPWNq4RRoqP1ZiRZF5m1rkxLjOizL6gQk84IZdEe+W9r87Agbbax/wBxQKGIqezc9BpfptLzicarYksXwKXFu8tluSeQ+EbWwtNFBbONQB0PW2nS8c4vGoF4ktBgqRBN6lrjly+EamBplWbx6ZgNOYJtfT0jnE41WQlhisAAFFMOSdwbDTykB0KkhhYjcSzKUssJCJeEBC2kaDAQJhSVNjOE7OdJyma1OiSYgsAJGpjUSUJcWcjo3FeJbnddvSOECLi01Ul1UCIY4RDObo9Z7IWOFpEnkD7/APRmf7Z1C+IHQAge4EmTOxmIJwqD8rOvz0lbxt81Ss/JEYDzao+UfITvOnn1rKqGlojN1OX5AxgNtZJRP+GDf/Kf8H+U5BQV6EfOZrSbhu8t3jh2U+EWOpPLppHtWy6mnUABu3i2voOfpK0uw0zNbpmNvhGFj1PxMxxb5LY1Sf8Al1ttDrvyO/nORqlbMy1stznvsbiw5ytznqfiYFj1PxMnA5LIYpRfwVbe/e+nOAxCEkKHRiDZma3O4vr1MrCfOOak9r5TbT57Rxhyq4ysFBYNewtZzZdgbXPPX4x2TmFfWxIz+1e4B332+Erwi2Ay1c9tBmGUnS4te87HuzcLTqaEfiO1tva3mdN7SWQlbFW1vbx8txz3hXsNWVrWs3jPP37SETTyk5H/ABW8R0sTuM3Sw9xiFKegK1rm2mcW2uecmjaVQRxooGW/hKu22lgOVrQxNVUORlqag2AYnS1usjB6S2Bpvew/EdTfl4tt5DalUvazdRryvbeWY7qW6WBxa80qkbG5Oq672PmPhHLiM3iFOuR+DRiAbWuDeVJJ2/WAc9T8TNcYzyq2NTQDusQNbmytra9v0+EbTxKhWYU6hBN3bYGwG+u95WZ2/M38xjbnzjiclxXdmANMlT4dTUvpY6c+cqKjEk5jc8z1hnPU/Exssx0W7EI2EqGwiCKJFNcxkVt4kzW46URrOwnOkNI8Tc6Yy7PEWNEdDKJUWzH4iMM7Ygaj0nEzN7dJ02XYzEWpVF/K9/5h/kZD45iAFZBu7gt6Le3zMj9kqlqtRb7oT6lWH/cZy4w16lug+pM6Y9OWU/s7KP8Agx/9gP1Egya7Wwij99TIBlqQRDFiSKIkDCFIZ1OIb90E2u1tTa259w+E5RJNKksQWDZkBBvcIdTe9zBGAFs6HW9ihNiecjRVYcxf3mTRtMLvYrmBBz38J/ETf6kwFXMylnVSAdcjXW4ta3pImdfyj+YxCw/Lb3mTS7TGRGKlqyG2Uew1rAdOevLnvOT4pgzWK20GgsCAbi1jpI0I0mzncsSx3JJPqY2EbKHQhCAQjYkAhCEBsIQkVzaEITLbsmwj4Qm4504RRCEI44jl75wMITN7dMelr2b/APUD+Gp9IcU/aH0H1MITePTGXbpX/YL6yLCE1WIQwMISNEiQhASIYQmVEIQgEIQgEIQgNhCEAhCEBIQhAIQhCv/Z",
            Price = 29.99m,
            OriginalPrice = 59.99m
        },
        
      };
    }

  }
}

