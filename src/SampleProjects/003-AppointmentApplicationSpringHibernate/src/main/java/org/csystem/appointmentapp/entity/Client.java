package org.csystem.appointmentapp.entity;

import javax.persistence.*;
import java.time.LocalDate;

@Entity
@Table(name = "clients")
public class Client {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "client_id")
    private int m_id;

    @Column(name = "name")
    private String m_name;

    @Column(name = "email", unique = true)
    private String m_email;

    @Column(name = "date")
    private LocalDate m_date;

    public int getId()
    {
        return m_id;
    }

    public void setId(int id)
    {
        m_id = id;
    }

    public String getName()
    {
        return m_name;
    }

    public void setName(String name)
    {
        m_name = name;
    }

    public String getEmail()
    {
        return m_email;
    }

    public void setEmail(String email)
    {
        m_email = email;
    }

    public LocalDate getDate()
    {
        return m_date;
    }

    public void setDate(LocalDate date)
    {
        m_date = date;
    }
    //...
}
